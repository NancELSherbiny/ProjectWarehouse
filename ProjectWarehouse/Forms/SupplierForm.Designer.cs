namespace ProjectWarehouse.Forms
{
    partial class SupplierForm
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
            btnUpdate = new Button();
            btnAdd = new Button();
            FaxTextBox = new TextBox();
            WebsiteTextBox = new TextBox();
            EmailTextBox = new TextBox();
            MobileTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            NameTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDisplay = new Button();
            listBoxSupplier = new ListBox();
            SupplierComboBox = new ComboBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(297, 190);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(297, 92);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FaxTextBox
            // 
            FaxTextBox.Location = new Point(135, 353);
            FaxTextBox.Margin = new Padding(3, 4, 3, 4);
            FaxTextBox.Name = "FaxTextBox";
            FaxTextBox.Size = new Size(114, 27);
            FaxTextBox.TabIndex = 35;
            // 
            // WebsiteTextBox
            // 
            WebsiteTextBox.Location = new Point(135, 299);
            WebsiteTextBox.Margin = new Padding(3, 4, 3, 4);
            WebsiteTextBox.Name = "WebsiteTextBox";
            WebsiteTextBox.Size = new Size(114, 27);
            WebsiteTextBox.TabIndex = 34;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(135, 245);
            EmailTextBox.Margin = new Padding(3, 4, 3, 4);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(114, 27);
            EmailTextBox.TabIndex = 33;
            // 
            // MobileTextBox
            // 
            MobileTextBox.Location = new Point(135, 194);
            MobileTextBox.Margin = new Padding(3, 4, 3, 4);
            MobileTextBox.Name = "MobileTextBox";
            MobileTextBox.Size = new Size(114, 27);
            MobileTextBox.TabIndex = 32;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(135, 147);
            PhoneTextBox.Margin = new Padding(3, 4, 3, 4);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(114, 27);
            PhoneTextBox.TabIndex = 31;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(135, 92);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(114, 27);
            NameTextBox.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 356);
            label7.Name = "label7";
            label7.Size = new Size(30, 20);
            label7.TabIndex = 28;
            label7.Text = "Fax";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 303);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 27;
            label6.Text = "website";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 256);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 26;
            label5.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 201);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 25;
            label4.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 147);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 24;
            label3.Text = "phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 92);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 23;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 22;
            label1.Text = "SupplierID";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(297, 295);
            btnDisplay.Margin = new Padding(3, 4, 3, 4);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(86, 31);
            btnDisplay.TabIndex = 21;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // listBoxSupplier
            // 
            listBoxSupplier.FormattingEnabled = true;
            listBoxSupplier.Location = new Point(406, 13);
            listBoxSupplier.Margin = new Padding(3, 4, 3, 4);
            listBoxSupplier.Name = "listBoxSupplier";
            listBoxSupplier.Size = new Size(366, 364);
            listBoxSupplier.TabIndex = 20;
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(135, 28);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(114, 28);
            SupplierComboBox.TabIndex = 40;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SupplierComboBox);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(FaxTextBox);
            Controls.Add(WebsiteTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(MobileTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDisplay);
            Controls.Add(listBoxSupplier);
            Name = "SupplierForm";
            Text = "SupplierForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbWarehouse;
        private Label label8;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox FaxTextBox;
        private TextBox WebsiteTextBox;
        private TextBox EmailTextBox;
        private TextBox MobileTextBox;
        private TextBox PhoneTextBox;
        private TextBox NameTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDisplay;
        private ListBox listBoxSupplier;
        private ComboBox SupplierComboBox;
    }
}