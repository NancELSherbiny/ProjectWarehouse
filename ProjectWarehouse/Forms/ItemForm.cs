using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjectWarehouse.Files;

namespace ProjectWarehouse
{
    public partial class ItemForm : Form
    {
        CompanyDbContext Ent = new CompanyDbContext();

        public ItemForm()
        {
            InitializeComponent();
            SeedItemUnits(); // Optional: to ensure units exist
            LoadItemUnits();
            LoadItems();
        }

        private void SeedItemUnits()
        {
            if (!Ent.ItemUnits.Any())
            {
                var units = new List<ItemUnit>
                {
                    new ItemUnit { Unit = "kg" },
                    new ItemUnit { Unit = "liter" },
                    new ItemUnit { Unit = "box" },
                    new ItemUnit { Unit = "piece" }
                };
                Ent.ItemUnits.AddRange(units);
                Ent.SaveChanges();
            }
        }

        private void LoadItemUnits()
        {
            var units = Ent.ItemUnits.ToList();
            UnitComboBox.DataSource = units;
            UnitComboBox.DisplayMember = "Unit";
            UnitComboBox.ValueMember = "ItemID";
        }

        private void LoadItems()
        {
            ItemListBox.Items.Clear();
            ItemListBox.Items.Add($"{"ID".PadRight(5)}{"Name".PadRight(20)}{"Unit".PadRight(10)}");

            ItemComboBox.Items.Clear();
            var items = Ent.Items.ToList();
            foreach (var item in items)
            {
                string unit = item.ItemUnit?.Unit ?? "N/A";
                ItemListBox.Items.Add($"{item.ID.ToString().PadRight(5)}{item.Name.PadRight(20)}{unit.PadRight(10)}");
                ItemComboBox.Items.Add(item.ID);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || UnitComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var selectedUnitId = (int)UnitComboBox.SelectedValue;

            Item newItem = new Item
            {
                Name = NameTextBox.Text,
                ItemUnitID = selectedUnitId
            };

            Ent.Items.Add(newItem);
            Ent.SaveChanges();
            MessageBox.Show("Item Added");
            LoadItems();
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedItem != null)
            {
                int selectedID = (int)ItemComboBox.SelectedItem;
                var item = Ent.Items.FirstOrDefault(i => i.ID == selectedID);

                if (item != null)
                {
                    NameTextBox.Text = item.Name;
                    UnitComboBox.SelectedValue = item.ItemUnitID;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            int selectedID = (int)ItemComboBox.SelectedItem;
            var item = Ent.Items.FirstOrDefault(i => i.ID == selectedID);

            if (item != null)
            {
                item.Name = NameTextBox.Text;
                item.ItemUnitID = (int)UnitComboBox.SelectedValue;

                Ent.SaveChanges();
                MessageBox.Show("Item Updated");
                LoadItems();
            }
            else
            {
                MessageBox.Show("Item not found.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            int selectedID = (int)ItemComboBox.SelectedItem;
            var item = Ent.Items.FirstOrDefault(i => i.ID == selectedID);

            if (item != null)
            {
                Ent.Items.Remove(item);
                Ent.SaveChanges();
                MessageBox.Show("Item Deleted");
                LoadItems();
            }
            else
            {
                MessageBox.Show("Item not found.");
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            LoadItems();
            MessageBox.Show("Items Refreshed", "Display");
        }

    }
}
