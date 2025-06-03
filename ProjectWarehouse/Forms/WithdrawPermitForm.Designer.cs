namespace ProjectWarehouse.Forms
{
    partial class WithdrawPermitForm
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
            WithdrawPermitListBox = new ListBox();
            QuantityTextBox = new TextBox();
            PermitTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ItemComboBox = new ComboBox();
            ClientComboBox = new ComboBox();
            WarehouseComboBox = new ComboBox();
            label3 = new Label();
            Client = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Location = new Point(578, 322);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 33;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(398, 322);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 32;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(574, 266);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 31;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(398, 266);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(94, 29);
            btn_display.TabIndex = 30;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // WithdrawPermitListBox
            // 
            WithdrawPermitListBox.FormattingEnabled = true;
            WithdrawPermitListBox.Location = new Point(305, 20);
            WithdrawPermitListBox.Name = "WithdrawPermitListBox";
            WithdrawPermitListBox.Size = new Size(481, 224);
            WithdrawPermitListBox.TabIndex = 29;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(134, 219);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(125, 27);
            QuantityTextBox.TabIndex = 26;
            // 
            // PermitTextBox
            // 
            PermitTextBox.Location = new Point(134, 178);
            PermitTextBox.Name = "PermitTextBox";
            PermitTextBox.Size = new Size(125, 27);
            PermitTextBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 222);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 24;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 185);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 23;
            label4.Text = "Permit ID";
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(134, 104);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(151, 28);
            ItemComboBox.TabIndex = 22;
            // 
            // ClientComboBox
            // 
            ClientComboBox.FormattingEnabled = true;
            ClientComboBox.Location = new Point(134, 56);
            ClientComboBox.Name = "ClientComboBox";
            ClientComboBox.Size = new Size(151, 28);
            ClientComboBox.TabIndex = 21;
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(134, 17);
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(151, 28);
            WarehouseComboBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 112);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 19;
            label3.Text = "Item ";
            // 
            // Client
            // 
            Client.AutoSize = true;
            Client.Location = new Point(15, 64);
            Client.Name = "Client";
            Client.Size = new Size(47, 20);
            Client.TabIndex = 18;
            Client.Text = "Client";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 17;
            label1.Text = "Warehouse ";
            // 
            // WithdrawPermitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Controls.Add(WithdrawPermitListBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(PermitTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ItemComboBox);
            Controls.Add(ClientComboBox);
            Controls.Add(WarehouseComboBox);
            Controls.Add(label3);
            Controls.Add(Client);
            Controls.Add(label1);
            Name = "WithdrawPermitForm";
            Text = "WithdrawPermitForm";
            Load += WithdrawPermitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private Button btn_update;
        private Button btn_add;
        private Button btn_display;
        private ListBox WithdrawPermitListBox;
        private TextBox QuantityTextBox;
        private TextBox PermitTextBox;
        private Label label5;
        private Label label4;
        private ComboBox ItemComboBox;
        private ComboBox ClientComboBox;
        private ComboBox WarehouseComboBox;
        private Label label3;
        private Label Client;
        private Label label1;
    }
}