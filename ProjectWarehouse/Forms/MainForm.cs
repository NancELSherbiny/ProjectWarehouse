using ProjectWarehouse.Forms;
using System;
using System.Windows.Forms;

namespace ProjectWarehouse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFormInTab(Form formInstance, string tabTitle)
        {
            foreach (TabPage page in mainTabControl.TabPages)
            {
                if (page.Text == tabTitle)
                {
                    mainTabControl.SelectedTab = page;
                    return;
                }
            }

            TabPage tabPage = new TabPage(tabTitle);
            formInstance.TopLevel = false;
            formInstance.FormBorderStyle = FormBorderStyle.None;
            formInstance.Dock = DockStyle.Fill;

            tabPage.Controls.Add(formInstance);
            mainTabControl.TabPages.Add(tabPage);
            mainTabControl.SelectedTab = tabPage;
            formInstance.Show();
        }


        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new WarehouseForm(), "Warehouse");
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new ItemForm(), "Items");
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new SupplierForm(), "Suppliers");
        }

        private void supplyPermitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new SupplyPermitForm(), "Supply Permit");
        }

        private void withdrawPermitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new WithdrawPermitForm(), "Withdraw Permit");
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new TransferForm(), "Transfer");
        }

        private void warehouseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new WarehouseReportForm(), "Warehouse Report");
        }

        private void itemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new ItemReportForm(), "Item Report");
        }

        private void itemMovementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new ItemMovementReportForm(), "Item Movement Report");
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientForm();
            OpenFormInTab(clientForm, "Clients");
        }

      
        private void agingItemsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new AgingItemReportForm(), "Aging Items Report");
        }

        private void expiryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInTab(new ExpiryReportForm(), "Expiry Report");
        }
    }
}
