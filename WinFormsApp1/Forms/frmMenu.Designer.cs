namespace StockS.API.Forms
{
    partial class frmMenu
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
            lblUserName = new Label();
            lblTitle = new Label();
            btnLogOut = new Button();
            btnClose = new Button();
            btnItems = new Button();
            btnAddCompany = new Button();
            btnRegister = new Button();
            btnRole = new Button();
            btnWriteOff = new Button();
            btnReceipt = new Button();
            btnConclusion = new Button();
            btnInve = new Button();
            btnShifts = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(426, 17);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(75, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "lblUserName";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(426, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "lblTitle";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(426, 76);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 23);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(426, 126);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(12, 9);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(201, 23);
            btnItems.TabIndex = 4;
            btnItems.Text = "List all items";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // btnAddCompany
            // 
            btnAddCompany.Location = new Point(12, 38);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(201, 23);
            btnAddCompany.TabIndex = 5;
            btnAddCompany.Text = "Add new company";
            btnAddCompany.UseVisualStyleBackColor = true;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 68);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(201, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register new user";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRole
            // 
            btnRole.Location = new Point(12, 97);
            btnRole.Name = "btnRole";
            btnRole.Size = new Size(201, 23);
            btnRole.TabIndex = 7;
            btnRole.Text = "Add role";
            btnRole.UseVisualStyleBackColor = true;
            btnRole.Click += btnRole_Click;
            // 
            // btnWriteOff
            // 
            btnWriteOff.Location = new Point(219, 38);
            btnWriteOff.Name = "btnWriteOff";
            btnWriteOff.Size = new Size(201, 23);
            btnWriteOff.TabIndex = 9;
            btnWriteOff.Text = "Write off";
            btnWriteOff.UseVisualStyleBackColor = true;
            btnWriteOff.Click += btnWriteOff_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(219, 9);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(201, 23);
            btnReceipt.TabIndex = 10;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnConclusion
            // 
            btnConclusion.Location = new Point(219, 125);
            btnConclusion.Name = "btnConclusion";
            btnConclusion.Size = new Size(201, 23);
            btnConclusion.TabIndex = 11;
            btnConclusion.Text = "Conclusion";
            btnConclusion.UseVisualStyleBackColor = true;
            btnConclusion.Click += btnConclusion_Click;
            // 
            // btnInve
            // 
            btnInve.Location = new Point(219, 67);
            btnInve.Name = "btnInve";
            btnInve.Size = new Size(201, 23);
            btnInve.TabIndex = 12;
            btnInve.Text = "Inventory";
            btnInve.UseVisualStyleBackColor = true;
            btnInve.Click += btnInve_Click;
            // 
            // btnShifts
            // 
            btnShifts.Location = new Point(219, 96);
            btnShifts.Name = "btnShifts";
            btnShifts.Size = new Size(201, 23);
            btnShifts.TabIndex = 13;
            btnShifts.Text = "Shift";
            btnShifts.UseVisualStyleBackColor = true;
            btnShifts.Click += btnShifts_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 226);
            Controls.Add(btnShifts);
            Controls.Add(btnInve);
            Controls.Add(btnConclusion);
            Controls.Add(btnReceipt);
            Controls.Add(btnWriteOff);
            Controls.Add(btnRole);
            Controls.Add(btnRegister);
            Controls.Add(btnAddCompany);
            Controls.Add(btnItems);
            Controls.Add(btnClose);
            Controls.Add(btnLogOut);
            Controls.Add(lblTitle);
            Controls.Add(lblUserName);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblTitle;
        private Button btnLogOut;
        private Button btnClose;
        private Button btnItems;
        private Button btnAddCompany;
        private Button btnRegister;
        private Button btnRole;
        private Button btnWriteOff;
        private Button btnReceipt;
        private Button btnConclusion;
        private Button btnInve;
        private Button btnShifts;
    }
}