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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProjectWarehouse.Forms
{
    public partial class ItemMovementReportForm : Form
    {
        CompanyDbContext db = new CompanyDbContext();
        public ItemMovementReportForm()
        {
            InitializeComponent();
        }

        private void ItemMovementReportForm_Load(object sender, EventArgs e)
        {
            var Warehouses = db.Warehouses.ToList();
            WarehouseComboBox.DataSource = Warehouses;
            WarehouseComboBox.DisplayMember = "Name";
            WarehouseComboBox.ValueMember = "Id";
            WarehouseComboBox.SelectedIndex = -1;
            var Items = db.Items.ToList();
            ItemComboBox.DataSource = Items;
            ItemComboBox.DisplayMember = "Name";
            ItemComboBox.ValueMember = "Id";
            ItemComboBox.SelectedIndex = -1;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            {
                int? warehouseId = WarehouseComboBox.SelectedValue as int?;
                int? itemId = ItemComboBox.SelectedValue as int?;

                using (var db = new CompanyDbContext())
                {
                    var supplyMovements = db.SupplyPermitItems
                        .Where(spi => (!warehouseId.HasValue || spi.SupplyPermit.WID == warehouseId)
                                      && (!itemId.HasValue || spi.ItemID == itemId))
                        .Select(spi => new
                        {
                            Date = spi.SupplyPermit.Date,
                            Movement = "Supply In",
                            ItemName = spi.Item.Name,
                            Quantity = spi.Quantity,
                            Warehouse = spi.SupplyPermit.Warehouse.Name
                        });

                    var withdrawMovements = db.WithdrawPermitItems
                        .Where(wpi => (!warehouseId.HasValue || wpi.WithdrawPermit.WID == warehouseId)
                                      && (!itemId.HasValue || wpi.ItemID == itemId))
                        .Select(wpi => new
                        {
                            Date = wpi.WithdrawPermit.Date,
                            Movement = "Withdraw",
                            ItemName = wpi.Item.Name,
                            Quantity = wpi.Quantity,
                            Warehouse = wpi.WithdrawPermit.Warehouse.Name
                        });

                    var transfersOut = db.TransferItems
                        .Where(ti => (!warehouseId.HasValue || ti.Transfer.FromW == warehouseId)
                                     && (!itemId.HasValue || ti.Item.ID == itemId))
                        .Select(ti => new
                        {
                            Date = ti.Transfer.Date,
                            Movement = "Transfer Out",
                            ItemName = ti.Item.Name,
                            Quantity = ti.Quantity,
                            Warehouse = ti.Transfer.FromWarehouse.Name
                        });

                    var transfersIn = db.TransferItems
                        .Where(ti => (!warehouseId.HasValue || ti.Transfer.ToW == warehouseId)
                                     && (!itemId.HasValue || ti.Item.ID == itemId))
                        .Select(ti => new
                        {
                            Date = ti.Transfer.Date,
                            Movement = "Transfer In",
                            ItemName = ti.Item.Name,
                            Quantity = ti.Quantity,
                            Warehouse = ti.Transfer.ToWarehouse.Name
                        });

                    var result = supplyMovements
                        .Union(withdrawMovements)
                        .Union(transfersOut)
                        .Union(transfersIn)
                        .OrderBy(r => r.Date)
                        .ToList();

                    dataGridView1.DataSource = result;
                }
            }
        }
    }
}
