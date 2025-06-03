using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjectWarehouse.Files;

namespace ProjectWarehouse.Forms
{
    public partial class SupplierForm : Form
    {
        CompanyDbContext Ent = new CompanyDbContext();

        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            listBoxSupplier.Items.Clear();
            listBoxSupplier.Items.Add($"{"ID".PadRight(5)}{"Name".PadRight(20)}{"Phone".PadRight(15)}{"Email".PadRight(25)}");

            SupplierComboBox.Items.Clear();
            var suppliers = Ent.Suppliers.ToList();

            foreach (var s in suppliers)
            {
                listBoxSupplier.Items.Add($"{s.ID.ToString().PadRight(5)}{s.Name.PadRight(20)}{s.Phone.PadRight(15)}{s.Email.PadRight(25)}");
                SupplierComboBox.Items.Add(s.ID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                MessageBox.Show("Please fill in at least name and phone.");
                return;
            }

            Supplier supplier = new Supplier
            {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Fax = FaxTextBox.Text,
                Mobile = MobileTextBox.Text,
                Email = EmailTextBox.Text,
                Website = WebsiteTextBox.Text
            };

            Ent.Suppliers.Add(supplier);
            Ent.SaveChanges();
            MessageBox.Show("Supplier Added");
            LoadSuppliers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SupplierComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            int id = (int)SupplierComboBox.SelectedItem;
            var supplier = Ent.Suppliers.FirstOrDefault(s => s.ID == id);

            if (supplier != null)
            {
                supplier.Name = NameTextBox.Text;
                supplier.Phone = PhoneTextBox.Text;
                supplier.Fax = FaxTextBox.Text;
                supplier.Mobile = MobileTextBox.Text;
                supplier.Email = EmailTextBox.Text;
                supplier.Website = WebsiteTextBox.Text;

                Ent.SaveChanges();
                MessageBox.Show("Supplier Updated");
                LoadSuppliers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SupplierComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            int id = (int)SupplierComboBox.SelectedItem;
            var supplier = Ent.Suppliers.FirstOrDefault(s => s.ID == id);

            if (supplier != null)
            {
                Ent.Suppliers.Remove(supplier);
                Ent.SaveChanges();
                MessageBox.Show("Supplier Deleted");
                LoadSuppliers();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
            MessageBox.Show("Suppliers Refreshed");
        }

        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierComboBox.SelectedItem != null)
            {
                int id = (int)SupplierComboBox.SelectedItem;
                var supplier = Ent.Suppliers.FirstOrDefault(s => s.ID == id);
                if (supplier != null)
                {
                    NameTextBox.Text = supplier.Name;
                    PhoneTextBox.Text = supplier.Phone;
                    FaxTextBox.Text = supplier.Fax;
                    MobileTextBox.Text = supplier.Mobile;
                    EmailTextBox.Text = supplier.Email;
                    WebsiteTextBox.Text = supplier.Website;
                }
            }
        }
    }
}
