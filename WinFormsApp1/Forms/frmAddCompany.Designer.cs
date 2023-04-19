namespace StockS.API.Forms
{
    partial class frmAddCompany
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
            txtOIB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtAdress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtMail = new TextBox();
            btnCommit = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtOIB
            // 
            txtOIB.Location = new Point(12, 26);
            txtOIB.Name = "txtOIB";
            txtOIB.Size = new Size(283, 23);
            txtOIB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "OIB";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 23);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Adress";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(12, 118);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(283, 23);
            txtAdress.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Telephone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(283, 23);
            txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(12, 210);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(283, 23);
            txtMail.TabIndex = 8;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(220, 254);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 10;
            btnCommit.Text = "Add";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(139, 254);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.TabStop = false;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 291);
            Controls.Add(btnClose);
            Controls.Add(btnCommit);
            Controls.Add(label5);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtAdress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtOIB);
            Name = "frmAddCompany";
            Text = "frmAddCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOIB;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtAdress;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtMail;
        private Button btnCommit;
        private Button btnClose;
    }
}