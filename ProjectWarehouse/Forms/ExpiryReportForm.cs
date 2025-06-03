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
    public partial class ExpiryReportForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();
        public ExpiryReportForm()
        {
            InitializeComponent();
        }

        private void ExpiryReportForm_Load(object sender, EventArgs e)
        {
            var Warehouses = db.Warehouses.ToList();
            WarehouseComboBox.DataSource = Warehouses;
            WarehouseComboBox.DisplayMember = "Name";
            WarehouseComboBox.ValueMember = "Id";
           

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            {
                if (WarehouseComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a warehouse.");
                    return;
                }

                int warehouseId = (int)WarehouseComboBox.SelectedValue;
                int thresholdDays = (int)numericUpDown1.Value;
                DateTime thresholdDate = DateTime.Now.AddDays(thresholdDays);

                var expiringItems = db.SupplyPermitItems
             .Include(spi => spi.Item)
             .Include(spi => spi.SupplyPermit)
             .Where(spi => spi.SupplyPermit.WID == warehouseId
                           && spi.ExpiryDate <= thresholdDate)
             .Select(spi => new
             {
                 spi.Item.Name,
                 spi.Quantity,
                 spi.ProductionDate,
                 spi.ExpiryDate,
                 DaysUntilExpiry = EF.Functions.DateDiffDay(DateTime.Now, spi.ExpiryDate)
             })
             .ToList();

                MessageBox.Show($"Found {expiringItems.Count} items close to expiry.");

                dataGridView1.DataSource = expiringItems;
            }
        }
    }
}
