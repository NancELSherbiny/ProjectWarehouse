namespace ProjectWarehouse.Forms
{
    partial class AgingItemReportForm
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
            label2 = new Label();
            WarehouseComboBox = new ComboBox();
            label1 = new Label();
            btn_view = new Button();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 201);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 19;
            label2.Text = "Choose Warehouse";
            // 
            // WarehouseComboBox
            // 
            WarehouseComboBox.FormattingEnabled = true;
            WarehouseComboBox.Location = new Point(143, 236);
            WarehouseComboBox.Name = "WarehouseComboBox";
            WarehouseComboBox.Size = new Size(151, 28);
            WarehouseComboBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 201);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 17;
            label1.Text = "Threshold";
            // 
            // btn_view
            // 
            btn_view.Location = new Point(551, 236);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(94, 29);
            btn_view.TabIndex = 15;
            btn_view.Text = "View";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(742, 141);
            dataGridView1.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(350, 236);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 20;
            // 
            // AgingItemReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(WarehouseComboBox);
            Controls.Add(label1);
            Controls.Add(btn_view);
            Controls.Add(dataGridView1);
            Name = "AgingItemReportForm";
            Text = "AgingItemReportForm";
            Load += AgingItemReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox WarehouseComboBox;
        private Label label1;
        private Button btn_view;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
    }
}