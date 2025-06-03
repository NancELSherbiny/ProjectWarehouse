namespace ProjectWarehouse
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dataToolStripMenuItem = new ToolStripMenuItem();
            warehouseToolStripMenuItem = new ToolStripMenuItem();
            itemToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            supplyPermitToolStripMenuItem = new ToolStripMenuItem();
            withdrawPermitToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            warehouseReportToolStripMenuItem = new ToolStripMenuItem();
            itemReportToolStripMenuItem = new ToolStripMenuItem();
            itemMovementReportToolStripMenuItem = new ToolStripMenuItem();
            agingItemsReportToolStripMenuItem = new ToolStripMenuItem();
            expiryReportToolStripMenuItem = new ToolStripMenuItem();
            mainTabControl = new TabControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataToolStripMenuItem, transactionsToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warehouseToolStripMenuItem, itemToolStripMenuItem, supplierToolStripMenuItem, clientToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(55, 24);
            dataToolStripMenuItem.Text = "Data";
            // 
            // warehouseToolStripMenuItem
            // 
            warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            warehouseToolStripMenuItem.Size = new Size(165, 26);
            warehouseToolStripMenuItem.Text = "Warehouse";
            warehouseToolStripMenuItem.Click += warehouseToolStripMenuItem_Click;
            // 
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(165, 26);
            itemToolStripMenuItem.Text = "Item";
            itemToolStripMenuItem.Click += itemToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(165, 26);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(165, 26);
            clientToolStripMenuItem.Text = "Client";
            clientToolStripMenuItem.Click += clientToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supplyPermitToolStripMenuItem, withdrawPermitToolStripMenuItem, transferToolStripMenuItem });
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(104, 24);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // supplyPermitToolStripMenuItem
            // 
            supplyPermitToolStripMenuItem.Name = "supplyPermitToolStripMenuItem";
            supplyPermitToolStripMenuItem.Size = new Size(202, 26);
            supplyPermitToolStripMenuItem.Text = "Supply Permit";
            supplyPermitToolStripMenuItem.Click += supplyPermitToolStripMenuItem_Click;
            // 
            // withdrawPermitToolStripMenuItem
            // 
            withdrawPermitToolStripMenuItem.Name = "withdrawPermitToolStripMenuItem";
            withdrawPermitToolStripMenuItem.Size = new Size(202, 26);
            withdrawPermitToolStripMenuItem.Text = "Withdraw Permit";
            withdrawPermitToolStripMenuItem.Click += withdrawPermitToolStripMenuItem_Click;
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(202, 26);
            transferToolStripMenuItem.Text = "Transfer";
            transferToolStripMenuItem.Click += transferToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warehouseReportToolStripMenuItem, itemReportToolStripMenuItem, itemMovementReportToolStripMenuItem, agingItemsReportToolStripMenuItem, expiryReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // warehouseReportToolStripMenuItem
            // 
            warehouseReportToolStripMenuItem.Name = "warehouseReportToolStripMenuItem";
            warehouseReportToolStripMenuItem.Size = new Size(246, 26);
            warehouseReportToolStripMenuItem.Text = "Warehouse Report";
            warehouseReportToolStripMenuItem.Click += warehouseReportToolStripMenuItem_Click;
            // 
            // itemReportToolStripMenuItem
            // 
            itemReportToolStripMenuItem.Name = "itemReportToolStripMenuItem";
            itemReportToolStripMenuItem.Size = new Size(246, 26);
            itemReportToolStripMenuItem.Text = "Item Report";
            itemReportToolStripMenuItem.Click += itemReportToolStripMenuItem_Click;
            // 
            // itemMovementReportToolStripMenuItem
            // 
            itemMovementReportToolStripMenuItem.Name = "itemMovementReportToolStripMenuItem";
            itemMovementReportToolStripMenuItem.Size = new Size(246, 26);
            itemMovementReportToolStripMenuItem.Text = "Item Movement Report";
            itemMovementReportToolStripMenuItem.Click += itemMovementReportToolStripMenuItem_Click;
            // 
            // agingItemsReportToolStripMenuItem
            // 
            agingItemsReportToolStripMenuItem.Name = "agingItemsReportToolStripMenuItem";
            agingItemsReportToolStripMenuItem.Size = new Size(246, 26);
            agingItemsReportToolStripMenuItem.Text = "Aging Items Report";
            agingItemsReportToolStripMenuItem.Click += agingItemsReportToolStripMenuItem_Click;
            // 
            // expiryReportToolStripMenuItem
            // 
            expiryReportToolStripMenuItem.Name = "expiryReportToolStripMenuItem";
            expiryReportToolStripMenuItem.Size = new Size(246, 26);
            expiryReportToolStripMenuItem.Text = "Expiry Report";
            expiryReportToolStripMenuItem.Click += expiryReportToolStripMenuItem_Click;
            // 
            // mainTabControl
            // 
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 28);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 422);
            mainTabControl.TabIndex = 1;
          
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem warehouseToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem supplyPermitToolStripMenuItem;
        private ToolStripMenuItem withdrawPermitToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem warehouseReportToolStripMenuItem;
        private ToolStripMenuItem itemReportToolStripMenuItem;
        private ToolStripMenuItem itemMovementReportToolStripMenuItem;
        private ToolStripMenuItem agingItemsReportToolStripMenuItem;
        private ToolStripMenuItem expiryReportToolStripMenuItem;
        private TabControl mainTabControl;
    }
}
