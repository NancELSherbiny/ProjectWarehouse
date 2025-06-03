using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWarehouse.Files;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProjectWarehouse
{
    public partial class WarehouseForm : Form
    {
        CompanyDbContext Ent = new CompanyDbContext();
        public WarehouseForm()
        {
            InitializeComponent();
            LoadWarehouses();
        }

        public void LoadWarehouses()
        {
            WarehouseListBox.Items.Clear();
            WarehouseListBox.Items.Add(
                $"{"ID".PadRight(5)}{"Name".PadRight(20)}{"Location".PadRight(20)}{"Manager".PadRight(20)}");

            var warehouses = Ent.Warehouses.ToList();
            if (warehouses.Count == 0)
            {
                MessageBox.Show("No warehouses found.");
                return;
            }

            foreach (var warehouse in warehouses)
            {
                WarehouseListBox.Items.Add(
                    $"{warehouse.ID.ToString().PadRight(5)}{warehouse.Name.PadRight(20)}{warehouse.Location.PadRight(20)}{warehouse.Manager.PadRight(20)}");
                WarehouseComboBox.Items.Add(warehouse.ID); 
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            LoadWarehouses(); 
            MessageBox.Show("Data Refreshed!", "Display");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LocationTextBox.Text) || string.IsNullOrWhiteSpace(ManagerTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Warehouse newWarehouse = new Warehouse
            {
                Name = NameTextBox.Text,
                Location = LocationTextBox.Text,
                Manager = ManagerTextBox.Text
            };
            Ent.Warehouses.Add(newWarehouse);
            Ent.SaveChanges();
            MessageBox.Show("Warehouse Added");
        }


        private void WarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WarehouseComboBox.SelectedItem != null)
            {
                int selectedID = (int)WarehouseComboBox.SelectedItem;

                var warehouse = Ent.Warehouses.FirstOrDefault(w => w.ID == selectedID);
                if (warehouse != null)
                {
                    NameTextBox.Text = warehouse.Name;
                    LocationTextBox.Text = warehouse.Location;
                    ManagerTextBox.Text = warehouse.Manager;
                }
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(WarehouseComboBox.SelectedItem.ToString());
            var Warehouses = (from i in Ent.Warehouses
                              where i.ID == ID
                              select i).FirstOrDefault();
            if (WarehouseComboBox.SelectedItem != null)
            {
                int selectedID = (int)WarehouseComboBox.SelectedItem;

                var warehouse = Ent.Warehouses.FirstOrDefault(w => w.ID == selectedID);
                if (warehouse != null)
                {
                    warehouse.Name = NameTextBox.Text;
                    warehouse.Location = LocationTextBox.Text;
                    warehouse.Manager = ManagerTextBox.Text;

                    Ent.SaveChanges();
                    MessageBox.Show("Warehouse Updated");
                }
                else
                {
                    MessageBox.Show("Warehouse not found");
                }
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(WarehouseComboBox.SelectedItem.ToString());
            var Warehouses = (from i in Ent.Warehouses
                              where i.ID == ID
                              select i).FirstOrDefault();
            if (WarehouseComboBox.SelectedItem != null)
            {
                int selectedID = (int)WarehouseComboBox.SelectedItem;

                var warehouse = Ent.Warehouses.FirstOrDefault(w => w.ID == selectedID);
                if (warehouse != null)
                {
                    Ent.Warehouses.Remove(Warehouses);
                    Ent.SaveChanges();
                    MessageBox.Show("Warehouse deleted");
                }
                else
                {
                    MessageBox.Show("Warehouse not found");
                    Ent.SaveChanges();
                }

            }


        }
    }
}
