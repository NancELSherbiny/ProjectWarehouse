namespace ProjectWarehouse.Forms
{
    partial class SupplyPermitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            WarehouseComboBox = new ComboBox();
            SupplierComboBox = new ComboBox();
            ItemComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            PermitTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            label6 = new Label();
            numericExpiry = new NumericUpDown();
            SupplyPermitListBox = new ListBox();
            btn_display = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)numericExpiry).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Warehouse ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Supplier ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 107);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Item ";
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(136, 12);
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(151, 28);
            WarehouseComboBox.TabIndex = 3;
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(136, 51);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(151, 28);
            SupplierComboBox.TabIndex = 4;
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(136, 99);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(151, 28);
            ItemComboBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 180);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Permit ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 217);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            // 
            // PermitTextBox
            // 
            PermitTextBox.Location = new Point(136, 173);
            PermitTextBox.Name = "PermitTextBox";
            PermitTextBox.Size = new Size(125, 27);
            PermitTextBox.TabIndex = 8;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(136, 214);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(125, 27);
            QuantityTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 297);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 10;
            label6.Text = "Expiry Period in months";
            // 
            // numericExpiry
            // 
            numericExpiry.Location = new Point(136, 320);
            numericExpiry.Name = "numericExpiry";
            numericExpiry.Size = new Size(125, 27);
            numericExpiry.TabIndex = 11;
            // 
            // SupplyPermitListBox
            // 
            SupplyPermitListBox.FormattingEnabled = true;
            SupplyPermitListBox.Location = new Point(293, 15);
            SupplyPermitListBox.Name = "SupplyPermitListBox";
            SupplyPermitListBox.Size = new Size(495, 204);
            SupplyPermitListBox.TabIndex = 12;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(433, 239);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(94, 29);
            btn_display.TabIndex = 13;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(609, 239);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(433, 293);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(609, 293);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 16;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // SupplyPermitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Controls.Add(SupplyPermitListBox);
            Controls.Add(numericExpiry);
            Controls.Add(label6);
            Controls.Add(QuantityTextBox);
            Controls.Add(PermitTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ItemComboBox);
            Controls.Add(SupplierComboBox);
            Controls.Add(WarehouseComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SupplyPermitForm";
            Text = "SupplyPermitForm";
            Load += SupplyPermitForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericExpiry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox WarehouseComboBox;
        private ComboBox SupplierComboBox;
        private ComboBox ItemComboBox;
        private Label label4;
        private Label label5;
        private TextBox PermitTextBox;
        private TextBox QuantityTextBox;
        private Label label6;
        private NumericUpDown numericExpiry;
        private ListBox SupplyPermitListBox;
        private Button btn_display;
        private Button btn_add;
        private Button btn_update;
        private Button btn_save;
    }
}