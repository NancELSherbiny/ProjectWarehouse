namespace ProjectWarehouse.Forms
{
    partial class WarehouseReportForm
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
            dataGridView1 = new DataGridView();
            btn_view = new Button();
            WarehouseComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(742, 180);
            dataGridView1.TabIndex = 0;
            // 
            // btn_view
            // 
            btn_view.Location = new Point(419, 259);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(94, 29);
            btn_view.TabIndex = 1;
            btn_view.Text = "View";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(218, 259);
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(151, 28);
            WarehouseComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 224);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 3;
            label1.Text = "Choose Warehouse";
            // 
            // WarehouseReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(WarehouseComboBox);
            Controls.Add(btn_view);
            Controls.Add(dataGridView1);
            Name = "WarehouseReportForm";
            Text = "WarehouseReport";
            Load += WarehouseReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_view;
        private ComboBox WarehouseComboBox;
        private Label label1;
    }
}