namespace ProjectWarehouse.Forms
{
    partial class ItemMovementReportForm
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
            ItemComboBox = new ComboBox();
            btn_view = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            WarehouseComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 219);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 11;
            label1.Text = "Choose Item";
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(351, 254);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(151, 28);
            ItemComboBox.TabIndex = 10;
            // 
            // btn_view
            // 
            btn_view.Location = new Point(552, 254);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(94, 29);
            btn_view.TabIndex = 9;
            btn_view.Text = "View";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(742, 141);
            dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 219);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 13;
            label2.Text = "Choose Warehouse";
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(144, 254);
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(151, 28);
            WarehouseComboBox.TabIndex = 12;
            // 
            // ItemMovementReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(WarehouseComboBox);
            Controls.Add(label1);
            Controls.Add(ItemComboBox);
            Controls.Add(btn_view);
            Controls.Add(dataGridView1);
            Name = "ItemMovementReportForm";
            Text = "ItemMovementReportForm";
            Load += ItemMovementReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ItemComboBox;
        private Button btn_view;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox WarehouseComboBox;
    }
}