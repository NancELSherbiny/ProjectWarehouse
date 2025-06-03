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
    public partial class AgingItemReportForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();
        public AgingItemReportForm()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            WarehouseComboBox.DataSource = db.Warehouses.ToList();
            WarehouseComboBox.DisplayMember = "Name";
            WarehouseComboBox.ValueMember = "ID";
        }

        private void AgingItemReportForm_Load(object sender, EventArgs e)
        {
            int threshold = (int)numericUpDown1.Value;
            DateTime thresholdDate = DateTime.Now.AddDays(-threshold);
            int warehouseId = (int)WarehouseComboBox.SelectedValue;

            var agingItems = from spi in db.SupplyPermitItems
                             join sp in db.SupplyPermits on spi.SPID equals sp.ID
                             join item in db.Items on spi.ItemID equals item.ID
                             where sp.WID == warehouseId && sp.Date <= thresholdDate
                             select new
                             {
                                 item.Name,
                                 sp.Date,
                                 spi.Quantity,
                                 DaysStored = EF.Functions.DateDiffDay(sp.Date, DateTime.Now)
                             };

            dataGridView1.DataSource = agingItems.ToList();
        }
    }
}
