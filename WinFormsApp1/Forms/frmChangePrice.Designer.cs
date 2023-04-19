namespace StockS.API.Forms
{
    partial class frmChangePrice
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
            lblID = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 315);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(168, 315);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 1;
            btnCommit.Text = "Change";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 52);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 15);
            lblPrice.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(143, 49);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 4;
            // 
            // frmChangePrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 350);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblID);
            Controls.Add(btnCommit);
            Controls.Add(btnClose);
            Name = "frmChangePrice";
            Text = "frmChangePrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnCommit;
        private Label lblID;
        private Label lblPrice;
        private TextBox txtPrice;
    }
}