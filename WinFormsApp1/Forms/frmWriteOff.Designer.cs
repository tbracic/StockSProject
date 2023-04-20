namespace StockS.API.Forms
{
    partial class frmWriteOff
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
            lblNO = new Label();
            label2 = new Label();
            cBoxItem = new ComboBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            btnClose = new Button();
            btnCommit = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Write Off No.: ";
            // 
            // lblNO
            // 
            lblNO.AutoSize = true;
            lblNO.Location = new Point(101, 9);
            lblNO.Name = "lblNO";
            lblNO.Size = new Size(38, 15);
            lblNO.TabIndex = 1;
            lblNO.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Item:";
            // 
            // cBoxItem
            // 
            cBoxItem.FormattingEnabled = true;
            cBoxItem.Location = new Point(101, 35);
            cBoxItem.Name = "cBoxItem";
            cBoxItem.Size = new Size(121, 23);
            cBoxItem.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(101, 64);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(101, 93);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(121, 23);
            txtDescription.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 134);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(147, 134);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 7;
            btnCommit.Text = "Add";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "New quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // frmWriteOff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 183);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCommit);
            Controls.Add(btnClose);
            Controls.Add(txtDescription);
            Controls.Add(txtQuantity);
            Controls.Add(cBoxItem);
            Controls.Add(label2);
            Controls.Add(lblNO);
            Controls.Add(label1);
            Name = "frmWriteOff";
            Text = "frmWriteOff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNO;
        private Label label2;
        private ComboBox cBoxItem;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private Button btnClose;
        private Button btnCommit;
        private Label label3;
        private Label label4;
    }
}