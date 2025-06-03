namespace ProjectWarehouse.Forms
{
    partial class ItemReportForm
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 238);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 7;
            label1.Text = "Choose Item";
            // 
            // ItemComboBox
            // 
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Location = new Point(234, 273);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(151, 28);
            ItemComboBox.TabIndex = 6;
            // 
            // btn_view
            // 
            btn_view.Location = new Point(435, 273);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(94, 29);
            btn_view.TabIndex = 5;
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
            dataGridView1.Size = new Size(742, 172);
            dataGridView1.TabIndex = 4;
            // 
            // ItemReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ItemComboBox);
            Controls.Add(btn_view);
            Controls.Add(dataGridView1);
            Name = "ItemReportForm";
            Text = "ItemReportForm";
            Load += ItemReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ItemComboBox;
        private Button btn_view;
        private DataGridView dataGridView1;
    }
}