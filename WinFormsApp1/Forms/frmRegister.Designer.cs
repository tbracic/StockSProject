namespace StockS.API.Forms
{
    partial class frmRegister
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
            btnCommit = new Button();
            label5 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtAdress = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtOIB = new TextBox();
            label6 = new Label();
            cBoxRoles = new ComboBox();
            label7 = new Label();
            txtPassword = new TextBox();
            label8 = new Label();
            txtSurrname = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(141, 401);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 23;
            btnClose.TabStop = false;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(222, 401);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 22;
            btnCommit.Text = "Add";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 243);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(12, 261);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(283, 23);
            txtMail.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 19;
            label4.Text = "Telephone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 216);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(283, 23);
            txtPhone.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 17;
            label3.Text = "Adress";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(12, 169);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(283, 23);
            txtAdress.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 23);
            txtName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 13;
            label1.Text = "OIB";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtOIB
            // 
            txtOIB.Location = new Point(12, 25);
            txtOIB.Name = "txtOIB";
            txtOIB.Size = new Size(283, 23);
            txtOIB.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 297);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 24;
            label6.Text = "Role";
            // 
            // cBoxRoles
            // 
            cBoxRoles.FormattingEnabled = true;
            cBoxRoles.Location = new Point(12, 316);
            cBoxRoles.Name = "cBoxRoles";
            cBoxRoles.Size = new Size(283, 23);
            cBoxRoles.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 341);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 26;
            label7.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 359);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 23);
            txtPassword.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 107);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 29;
            label8.Text = "Surrname";
            // 
            // txtSurrname
            // 
            txtSurrname.Location = new Point(12, 125);
            txtSurrname.Name = "txtSurrname";
            txtSurrname.Size = new Size(283, 23);
            txtSurrname.TabIndex = 28;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 436);
            Controls.Add(label8);
            Controls.Add(txtSurrname);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(cBoxRoles);
            Controls.Add(label6);
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
            Name = "frmRegister";
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnCommit;
        private Label label5;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAdress;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtOIB;
        private Label label6;
        private ComboBox cBoxRoles;
        private Label label7;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtSurrname;
    }
}