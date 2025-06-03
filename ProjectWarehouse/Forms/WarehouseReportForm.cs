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
    public partial class WarehouseReportForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();
        public WarehouseReportForm()
        {
            InitializeComponent();
        }


        private void WarehouseReportForm_Load(object sender, EventArgs e)
        {
            var Warehouses = db.Warehouses.ToList();
            WarehouseComboBox.DataSource = Warehouses;
            WarehouseComboBox.DisplayMember = "Name";
            WarehouseComboBox.ValueMember = "Id";

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (WarehouseComboBox.SelectedValue is int selectedWarehouseId)
            {
                using (var context = new CompanyDbContext())
                {
                    var report = db.Warehouses
                        .Where(w => w.ID == selectedWarehouseId)
                        .Select(w => new
                        {
                            w.Name,
                            w.Location,
                            w.Manager,

                            TotalItemsStored = db.SupplyPermitItems
                                .Where(spi => spi.SupplyPermit.WID == w.ID)
                                .Select(spi => spi.ItemID)
                                .Distinct()
                                .Count(),

                             TotalSupplyPermits = db.SupplyPermits
                                .Where(w => w.WID == w.ID)
                                .Select(sp => sp.ID)
                                .Distinct()
                                .Count(),

                            TotalWithdrawPermits = db.WithdrawPermits
                                .Where(w => w.WID == w.ID)
                                .Select(wp => wp.ID)
                                .Distinct()
                                .Count(),
                            TotalTransfersFrom = db.Transfers
                                .Where(t => t.FromW == w.ID)
                                .Select(t => t.ID)
                                .Distinct()
                                .Count(),
                            TotalTransfersTo = db.Transfers
                                .Where(t => t.ToW == w.ID)
                                .Select(t => t.ID)
                                .Distinct()
                                .Count()


                        })
                        .ToList();

                    dataGridView1.DataSource = report;
                }
            }
            else
            {
                MessageBox.Show("Please select a warehouse.");
            }
        }
    }
}

    

