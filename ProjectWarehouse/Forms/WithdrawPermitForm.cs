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


namespace ProjectWarehouse.Forms
{
    public partial class WithdrawPermitForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();
        List<WithdrawPermitItem> currentItems = new List<WithdrawPermitItem>();

        public WithdrawPermitForm()
        {
            InitializeComponent();
        }


        private void btn_display_Click(object sender, EventArgs e)
        {
            WithdrawPermitListBox.Items.Clear();
            var permits = db.WithdrawPermits
                .Include(w => w.Warehouse)
                .Include(w => w.Client)
                .Include(w => w.withdrawPermitItems)
                .ThenInclude(wpi => wpi.Item)
                .ToList();

            foreach (var permit in permits)
            {
                WithdrawPermitListBox.Items.Add($"Permit {permit.ID} - Warehouse: {permit.Warehouse.Name}, Client: {permit.Client.Name}, Date: {permit.Date.ToShortDateString()}");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            AddItemToPermit();
        }

        private void AddItemToPermit()
        {
            if (ItemComboBox.SelectedItem == null || !int.TryParse(QuantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Select a valid item and enter a positive quantity.");
                return;
            }

            currentItems.Add(new WithdrawPermitItem
            {
                ItemID = (int)ItemComboBox.SelectedValue,
                Quantity = quantity
            });

            RefreshItemList();
        }

        private void RefreshItemList()
        {
            WithdrawPermitListBox.Items.Clear();
            foreach (var item in currentItems)
            {
                var realItem = db.Items.Find(item.ItemID);
                string itemName = realItem?.Name ?? "Unknown";
                WithdrawPermitListBox.Items.Add($"Item: {itemName}, Qty: {item.Quantity}");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (WarehouseComboBox.SelectedValue == null || ClientComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select both a warehouse and a client.");
                return;
            }

            if (currentItems.Count == 0)
            {
                MessageBox.Show("Add at least one item before saving the permit.");
                return;
            }

            var permit = new WithdrawPermit
            {
                WID = (int)WarehouseComboBox.SelectedValue,
                CID = (int)ClientComboBox.SelectedValue,
                Date = DateTime.Now
            };

            db.WithdrawPermits.Add(permit);
            db.SaveChanges();

            foreach (var item in currentItems)
            {
                item.WPID = permit.ID;
                db.WithdrawPermitItems.Add(item);
            }

            db.SaveChanges();
            MessageBox.Show("Withdraw Permit and items saved to the database.");

            currentItems.Clear();
            WithdrawPermitListBox.Items.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(PermitTextBox.Text, out int permitId))
            {
                MessageBox.Show("Invalid Permit ID.");
                return;
            }

            var permit = db.WithdrawPermits.Include(w => w.withdrawPermitItems).FirstOrDefault(p => p.ID == permitId);
            if (permit == null)
            {
                MessageBox.Show("Permit not found.");
                return;
            }

            permit.WID = (int)WarehouseComboBox.SelectedValue;
            permit.CID = (int)ClientComboBox.SelectedValue;
            permit.Date = DateTime.Now;

            permit.withdrawPermitItems.Clear();
            foreach (var item in currentItems)
            {
                permit.withdrawPermitItems.Add(item);
            }

            db.SaveChanges();
            MessageBox.Show("Withdraw Permit Updated.");
        }

        private void WithdrawPermitForm_Load(object sender, EventArgs e)
        {
            WarehouseComboBox.DataSource = db.Warehouses.ToList();
            WarehouseComboBox.DisplayMember = "Name";
            WarehouseComboBox.ValueMember = "ID";

            ClientComboBox.DataSource = db.Clients.ToList();
            ClientComboBox.DisplayMember = "Name";
            ClientComboBox.ValueMember = "ID";

            ItemComboBox.DataSource = db.Items.ToList();
            ItemComboBox.DisplayMember = "Name";
            ItemComboBox.ValueMember = "ID";
        }
    }

}
