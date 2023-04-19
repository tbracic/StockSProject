namespace StockS.API.Forms
{
    partial class frmRole
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
            label1 = new Label();
            txtTitle = new TextBox();
            lblID = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 80);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(115, 80);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 1;
            btnCommit.Text = "Add";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "Role Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 36);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(178, 23);
            txtTitle.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(152, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(38, 15);
            lblID.TabIndex = 4;
            lblID.Text = "label2";
            // 
            // frmRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 111);
            Controls.Add(lblID);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(btnCommit);
            Controls.Add(btnClose);
            Name = "frmRole";
            Text = "frmRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnCommit;
        private Label label1;
        private TextBox txtTitle;
        private Label lblID;
    }
}