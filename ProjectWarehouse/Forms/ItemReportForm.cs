using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjectWarehouse.Files;

namespace ProjectWarehouse.Forms
{
    public partial class ItemReportForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();

        public ItemReportForm()
        {
            InitializeComponent();
        }

        private void ItemReportForm_Load(object sender, EventArgs e)
        {
            // Fix: Make sure to include the ID for ValueMember
            var itemReport = db.Items
                .Select(item => new
                {
                    item.ID,
                    item.Name,
                    UnitName = item.ItemUnit.Unit
                })
                .ToList();

            ItemComboBox.DataSource = itemReport;
            ItemComboBox.DisplayMember = "Name";
            ItemComboBox.ValueMember = "ID";
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedValue != null && int.TryParse(ItemComboBox.SelectedValue.ToString(), out int selectedItemId))
            {
                var itemDetails = db.Items
                    .Where(i => i.ID == selectedItemId)
                    .Select(i => new
                    {
                        i.ID,
                        i.Name,
                        Unit = i.ItemUnit.Unit,
                        SupplyCount = i.SupplyPermitItem.Sum(sp => (int?)sp.Quantity) ?? 0,
                        WithdrawCount = i.WithdrawPermitItem.Sum(wp => (int?)wp.Quantity) ?? 0,
                        TransferCount = i.TransferItem.Sum(tp => (int?)tp.Quantity) ?? 0
                    })
                    .ToList();

                dataGridView1.DataSource = itemDetails;
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }
    }
}
