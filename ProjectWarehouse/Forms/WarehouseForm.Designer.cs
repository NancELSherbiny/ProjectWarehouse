namespace ProjectWarehouse
{
    partial class WarehouseForm
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
            btn_display = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            WarehouseListBox = new ListBox();
            WarehouseComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameTextBox = new TextBox();
            LocationTextBox = new TextBox();
            ManagerTextBox = new TextBox();
            SuspendLayout();
            // 
            // btn_display
            // 
            btn_display.Location = new Point(21, 215);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(94, 29);
            btn_display.TabIndex = 1;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(182, 215);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(21, 297);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(182, 297);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // WarehouseListBox
            // 
            WarehouseListBox.FormattingEnabled = true;
            WarehouseListBox.Location = new Point(313, 12);
            WarehouseListBox.Name = "WarehouseListBox";
            WarehouseListBox.Size = new Size(475, 384);
            WarehouseListBox.TabIndex = 6;
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(182, 12);
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(125, 28);
            WarehouseComboBox.TabIndex = 7;
            WarehouseComboBox.SelectedIndexChanged += WarehouseComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 9;
            label1.Text = "Warehouse ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 94);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 11;
            label3.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 138);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 12;
            label4.Text = "Manager";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(182, 46);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 13;
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(182, 87);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(125, 27);
            LocationTextBox.TabIndex = 14;
            // 
            // ManagerTextBox
            // 
            ManagerTextBox.Location = new Point(182, 131);
            ManagerTextBox.Name = "ManagerTextBox";
            ManagerTextBox.Size = new Size(125, 27);
            ManagerTextBox.TabIndex = 15;
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ManagerTextBox);
            Controls.Add(LocationTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WarehouseComboBox);
            Controls.Add(WarehouseListBox);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Name = "WarehouseForm";
            Text = "WarehouseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_display;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private ListBox WarehouseListBox;
        private ComboBox WarehouseComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameTextBox;
        private TextBox LocationTextBox;
        private TextBox ManagerTextBox;
    }
}