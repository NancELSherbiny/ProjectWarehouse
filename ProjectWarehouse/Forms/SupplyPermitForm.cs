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
    public partial class SupplyPermitForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();
        List<SupplyPermitItem> currentItems = new List<SupplyPermitItem>();

        public SupplyPermitForm()
        {
            InitializeComponent();
        }

        private void SupplyPermitForm_Load(object sender, EventArgs e)
        {
            WarehouseComboBox.DataSource = db.Warehouses.ToList();
            WarehouseComboBox.DisplayMember = "Name";
            WarehouseComboBox.ValueMember = "ID";

            SupplierComboBox.DataSource = db.Suppliers.ToList();
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";

            ItemComboBox.DataSource = db.Items.ToList();
            ItemComboBox.DisplayMember = "Name";
            ItemComboBox.ValueMember = "ID";
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            SupplyPermitListBox.Items.Clear();
            var permits = db.SupplyPermits
                .Include(p => p.Warehouse)
                .Include(p => p.Supplier)
                .Include(p => p.supplyPermitItems)
                .ThenInclude(spi => spi.Item)
                .ToList();

            foreach (var permit in permits)
            {
                SupplyPermitListBox.Items.Add($"Permit {permit.ID} - Warehouse: {permit.Warehouse.Name}, Supplier: {permit.Supplier.Name}, Date: {permit.Date.ToShortDateString()}");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (WarehouseComboBox.SelectedValue == null || SupplierComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select both a warehouse and a supplier.");
                return;
            }

            if (currentItems.Count == 0)
            {
                MessageBox.Show("Add at least one item before saving the permit.");
                return;
            }

            var permit = new SupplyPermit
            {
                WID = (int)WarehouseComboBox.SelectedValue,
                SID = (int)SupplierComboBox.SelectedValue,
                Date = DateTime.Now
            };

            db.SupplyPermits.Add(permit);
            db.SaveChanges(); // Get ID

            foreach (var item in currentItems)
            {
                item.SPID = permit.ID; // ✅ use SPID not ID!
                db.SupplyPermitItems.Add(item);
            }

            db.SaveChanges();
            MessageBox.Show("Supply Permit and items saved.");

            currentItems.Clear();
            SupplyPermitListBox.Items.Clear();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(PermitTextBox.Text, out int permitId))
            {
                MessageBox.Show("Invalid Permit ID.");
                return;
            }

            var permit = db.SupplyPermits
                .Include(p => p.supplyPermitItems)
                .FirstOrDefault(p => p.ID == permitId);

            if (permit == null)
            {
                MessageBox.Show("Permit not found.");
                return;
            }

            permit.WID = (int)WarehouseComboBox.SelectedValue;
            permit.SID = (int)SupplierComboBox.SelectedValue;
            permit.Date = DateTime.Now;

            // Remove existing items
            db.SupplyPermitItems.RemoveRange(permit.supplyPermitItems);

            // Add current items to permit
            foreach (var item in currentItems)
            {
                item.SPID = permit.ID;
                db.SupplyPermitItems.Add(item);
            }

            db.SaveChanges();
            MessageBox.Show("Supply Permit updated.");

            currentItems.Clear();
            SupplyPermitListBox.Items.Clear();
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

            DateTime prodDate = DateTime.Now;
            int expiryMonths = (int)numericExpiry.Value;
            DateTime expiryDate = prodDate.AddMonths(expiryMonths);

            currentItems.Add(new SupplyPermitItem
            {
                ItemID = (int)ItemComboBox.SelectedValue,
                Quantity = quantity,
                ProductionDate = prodDate,
                ExpiryDate = expiryDate
            });


            RefreshItemList();
        }

        private void RefreshItemList()
        {
            SupplyPermitListBox.Items.Clear();

            foreach (var item in currentItems)
            {
                var realItem = db.Items.Find(item.ItemID);
                string itemName = realItem?.Name ?? "Unknown";

                SupplyPermitListBox.Items.Add(
                    $"Item: {itemName}, Qty: {item.Quantity}, Prod: {item.ProductionDate.ToShortDateString()}, Exp: {item.ExpiryDate.ToShortDateString()}"
                );
            }
        }

        
    }
}
