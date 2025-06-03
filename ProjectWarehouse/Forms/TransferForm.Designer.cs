namespace ProjectWarehouse.Forms
{
    partial class TransferForm
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
            btn_save = new Button();
            btn_update = new Button();
            btn_add = new Button();
            btn_display = new Button();
            TransferPermitListBox = new ListBox();
            ItemComboBox = new ComboBox();
            label3 = new Label();
            From = new Label();
            label2 = new Label();
            label7 = new Label();
            FromComboBox = new ComboBox();
            ToComboBox = new ComboBox();
            SupplierComboBox = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            QuantityNumeric = new NumericUpDown();
            ProductionDateTime = new DateTimePicker();
            ExpiryDateTime = new DateTimePicker();
            label6 = new Label();
            TransferIdComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).BeginInit();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Location = new Point(584, 293);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 33;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(404, 293);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 32;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(580, 240);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 31;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(404, 240);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(94, 29);
            btn_display.TabIndex = 30;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // TransferPermitListBox
            // 
            TransferPermitListBox.FormattingEnabled = true;
            TransferPermitListBox.Location = new Point(269, 20);
            TransferPermitListBox.Name = "TransferPermitListBox";
            TransferPermitListBox.Size = new Size(517, 204);
            TransferPermitListBox.TabIndex = 29;
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(93, 145);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(151, 28);
            ItemComboBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 145);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 19;
            label3.Text = "Item ";
            // 
            // From
            // 
            From.AutoSize = true;
            From.Location = new Point(13, 20);
            From.Name = "From";
            From.Size = new Size(43, 20);
            From.TabIndex = 34;
            From.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 64);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 35;
            label2.Text = "To";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 102);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 36;
            label7.Text = "Supplier";
            // 
            // FromComboBox
            // 
            FromComboBox.FormattingEnabled = true;
            FromComboBox.Location = new Point(93, 20);
            FromComboBox.Name = "FromComboBox";
            FromComboBox.Size = new Size(151, 28);
            FromComboBox.TabIndex = 37;
            // 
            // ToComboBox
            // 
            ToComboBox.FormattingEnabled = true;
            ToComboBox.Location = new Point(93, 64);
            ToComboBox.Name = "ToComboBox";
            ToComboBox.Size = new Size(151, 28);
            ToComboBox.TabIndex = 38;
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(93, 102);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(151, 28);
            SupplierComboBox.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 240);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 40;
            label1.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 272);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 41;
            label4.Text = "Production";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 334);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 42;
            label5.Text = "Expiry";
            // 
            // QuantityNumeric
            // 
            QuantityNumeric.Location = new Point(93, 238);
            QuantityNumeric.Name = "QuantityNumeric";
            QuantityNumeric.Size = new Size(150, 27);
            QuantityNumeric.TabIndex = 43;
            // 
            // ProductionDateTime
            // 
            ProductionDateTime.Location = new Point(13, 295);
            ProductionDateTime.Name = "ProductionDateTime";
            ProductionDateTime.Size = new Size(250, 27);
            ProductionDateTime.TabIndex = 44;
            // 
            // ExpiryDateTime
            // 
            ExpiryDateTime.Location = new Point(13, 357);
            ExpiryDateTime.Name = "ExpiryDateTime";
            ExpiryDateTime.Size = new Size(250, 27);
            ExpiryDateTime.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 200);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 46;
            label6.Text = "Transfer ID";
            // 
            // TransferIdComboBox
            // 
            TransferIdComboBox.FormattingEnabled = true;
            TransferIdComboBox.Location = new Point(102, 197);
            TransferIdComboBox.Name = "TransferIdComboBox";
            TransferIdComboBox.Size = new Size(151, 28);
            TransferIdComboBox.TabIndex = 47;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TransferIdComboBox);
            Controls.Add(label6);
            Controls.Add(ExpiryDateTime);
            Controls.Add(ProductionDateTime);
            Controls.Add(QuantityNumeric);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(SupplierComboBox);
            Controls.Add(ToComboBox);
            Controls.Add(FromComboBox);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(From);
            Controls.Add(btn_save);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Controls.Add(TransferPermitListBox);
            Controls.Add(ItemComboBox);
            Controls.Add(label3);
            Name = "TransferForm";
            Text = "TransferForm";
            Load += TransferForm_Load;
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private Button btn_update;
        private Button btn_add;
        private Button btn_display;
        private ListBox TransferPermitListBox;
        private ComboBox ItemComboBox;
        private Label label3;
        private Label From;
        private Label label2;
        private Label label7;
        private ComboBox FromComboBox;
        private ComboBox ToComboBox;
        private ComboBox SupplierComboBox;
        private Label label1;
        private Label label4;
        private Label label5;
        private NumericUpDown QuantityNumeric;
        private DateTimePicker ProductionDateTime;
        private DateTimePicker ExpiryDateTime;
        private Label label6;
        private ComboBox TransferIdComboBox;
    }
}