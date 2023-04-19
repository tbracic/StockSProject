namespace StockS.API.Forms
{
    partial class frmAddItems
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
            btnClose = new Button();
            btnAdd = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cBoxCompany = new ComboBox();
            cBoxUnits = new ComboBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 304);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(87, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(115, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(102, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(102, 23);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(56, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 23);
            txtName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(102, 117);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(102, 23);
            txtQuantity.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(102, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(102, 23);
            txtPrice.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Item no. :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 10;
            label5.Text = "Units";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 183);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "Made by:";
            // 
            // cBoxCompany
            // 
            cBoxCompany.FormattingEnabled = true;
            cBoxCompany.Location = new Point(83, 180);
            cBoxCompany.Name = "cBoxCompany";
            cBoxCompany.Size = new Size(121, 23);
            cBoxCompany.TabIndex = 13;
            // 
            // cBoxUnits
            // 
            cBoxUnits.FormattingEnabled = true;
            cBoxUnits.Location = new Point(83, 151);
            cBoxUnits.Name = "cBoxUnits";
            cBoxUnits.Size = new Size(121, 23);
            cBoxUnits.TabIndex = 14;
            // 
            // frmAddItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 339);
            Controls.Add(cBoxUnits);
            Controls.Add(cBoxCompany);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Name = "frmAddItems";
            Text = "Add new item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnAdd;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cBoxCompany;
        private ComboBox cBoxUnits;
    }
}