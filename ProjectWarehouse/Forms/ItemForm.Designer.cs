namespace ProjectWarehouse
{
    partial class ItemForm
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
            NameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ItemID = new Label();
            ItemComboBox = new ComboBox();
            ItemListBox = new ListBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            btn_display = new Button();
            UnitComboBox = new ComboBox();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(178, 104);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 152);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 24;
            label3.Text = "Item Unit(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 111);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 23;
            label2.Text = "Name";
            // 
            // ItemID
            // 
            ItemID.AutoSize = true;
            ItemID.Location = new Point(17, 75);
            ItemID.Name = "ItemID";
            ItemID.Size = new Size(58, 20);
            ItemID.TabIndex = 22;
            ItemID.Text = "Item ID";
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(178, 70);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(125, 28);
            ItemComboBox.TabIndex = 21;
            ItemComboBox.SelectedIndexChanged += ItemComboBox_SelectedIndexChanged;
            // 
            // ItemListBox
            // 
            ItemListBox.FormattingEnabled = true;
            ItemListBox.Location = new Point(326, 33);
            ItemListBox.Name = "ItemListBox";
            ItemListBox.Size = new Size(458, 184);
            ItemListBox.TabIndex = 20;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(574, 290);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 19;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(413, 290);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 18;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(574, 242);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 17;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(413, 242);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(94, 29);
            btn_display.TabIndex = 16;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // UnitComboBox
            // 
            UnitComboBox.FormattingEnabled = true;
            UnitComboBox.Location = new Point(178, 149);
            UnitComboBox.Name = "UnitComboBox";
            UnitComboBox.Size = new Size(125, 28);
            UnitComboBox.TabIndex = 27;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UnitComboBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ItemID);
            Controls.Add(ItemComboBox);
            Controls.Add(ItemListBox);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_display);
            Name = "ItemForm";
            Text = "ItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameTextBox;
        private Label label3;
        private Label label2;
        private Label ItemID;
        private ComboBox ItemComboBox;
        private ListBox ItemListBox;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Button btn_display;
        private ComboBox UnitComboBox;
    }
}