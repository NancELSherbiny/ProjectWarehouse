using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ProjectWarehouse.Files;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProjectWarehouse.Forms
{
    public partial class TransferForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();
        List<TransferItem> currentItems = new List<TransferItem>();
        public TransferForm()
        {
            InitializeComponent();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            FromComboBox.DataSource = db.Warehouses.ToList();
            FromComboBox.DisplayMember = "Name";
            FromComboBox.ValueMember = "ID";
            ToComboBox.DataSource = db.Warehouses.ToList();
            ToComboBox.DisplayMember = "Name";
            ToComboBox.ValueMember = "ID";
            SupplierComboBox.DataSource = db.Suppliers.ToList();
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
            ItemComboBox.DataSource = db.Items.ToList();
            ItemComboBox.DisplayMember = "Name";
            ItemComboBox.ValueMember = "ID";
            LoadTransfersIntoComboBox();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            TransferPermitListBox.Items.Clear();
            var transfers = db.Transfers
                .Include(t => t.FromWarehouse)
                .Include(t => t.ToWarehouse)
                .Include(t => t.Supplier)
                .Include(t => t.TransferItems)
                .ThenInclude(ti => ti.Item)
                .ToList();
            foreach (var transfer in transfers)
            {
                TransferPermitListBox.Items.Add($"Transfer {transfer.ID} - From: {transfer.FromWarehouse.Name}, To: {transfer.ToWarehouse.Name}, Supplier: {transfer.Supplier.Name}, Date: {transfer.Date.ToShortDateString()}");
            }

        }

        private void RefreshItemList()
        {
            TransferPermitListBox.Items.Clear();
            foreach (var item in currentItems)
            {
                var realItem = db.Items.Find(item.IID);
                string name = realItem?.Name ?? "Unknown";

                TransferPermitListBox.Items.Add($"Item: {name}, Qty: {item.Quantity}, Prod: {item.ProductionDate.ToShortDateString()}, Exp: {item.ExpiryDate.ToShortDateString()}");
            }
        }

        private void LoadTransfersIntoComboBox()
        {
            TransferIdComboBox.DataSource = db.Transfers
                .Select(t => new { t.ID })
                .ToList();
            TransferIdComboBox.DisplayMember = "ID";
            TransferIdComboBox.ValueMember = "ID";
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item and enter a quantity.");
                return;
            }

            currentItems.Add(new TransferItem
            {
                IID = (int)ItemComboBox.SelectedValue,
                Quantity = (int)QuantityNumeric.Value,
                ProductionDate = ProductionDateTime.Value,
                ExpiryDate = ExpiryDateTime.Value
            });

            RefreshItemList();
            LoadTransfersIntoComboBox();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (TransferIdComboBox.SelectedValue == null)
            {
                MessageBox.Show("Select a transfer ID to update.");
                return;
            }

            int transferId = (int)TransferIdComboBox.SelectedValue;

            var transfer = db.Transfers
                             .Include(t => t.TransferItems)
                             .FirstOrDefault(t => t.ID == transferId);

            if (transfer == null)
            {
                MessageBox.Show("Transfer not found.");
                return;
            }

            // Update the base transfer data
            transfer.FromW = (int)FromComboBox.SelectedValue;
            transfer.ToW = (int)ToComboBox.SelectedValue;
            transfer.SID = (int)SupplierComboBox.SelectedValue;
            transfer.Date = DateTime.Now;

            // Remove old items
            db.TransferItems.RemoveRange(transfer.TransferItems);

            // Add new updated items
            foreach (var item in currentItems)
            {
                item.TransferID = transfer.ID;
                db.TransferItems.Add(item);
            }

            db.SaveChanges();

            MessageBox.Show("Transfer updated successfully.");
            currentItems.Clear();
            TransferPermitListBox.Items.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (FromComboBox.SelectedValue == null || ToComboBox.SelectedValue == null || SupplierComboBox.SelectedValue == null)
            {
                MessageBox.Show("Select From, To warehouses and a Supplier.");
                return;
            }

            if (currentItems.Count == 0)
            {
                MessageBox.Show("Add at least one item before saving.");
                return;
            }

            var transfer = new Transfer
            {
                FromW = (int)FromComboBox.SelectedValue,
                ToW = (int)ToComboBox.SelectedValue,
                SID = (int)SupplierComboBox.SelectedValue,
                Date = DateTime.Now
            };

            db.Transfers.Add(transfer);
            db.SaveChanges();

            foreach (var item in currentItems)
            {
                item.TransferID = transfer.ID;
                db.TransferItems.Add(item);
            }

            db.SaveChanges();
            MessageBox.Show("Transfer saved successfully.");

            currentItems.Clear();
            TransferPermitListBox.Items.Clear();
        }
    }
    }

