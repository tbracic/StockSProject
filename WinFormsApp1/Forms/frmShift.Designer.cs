namespace StockS.API.Forms
{
    partial class frmShift
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNo = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnCommit = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 108);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Shift start:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Shift end:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 9);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Shift. No:";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(163, 9);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(38, 15);
            lblNo.TabIndex = 4;
            lblNo.Text = "label4";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(101, 28);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(100, 23);
            txtStart.TabIndex = 5;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(101, 63);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(100, 23);
            txtEnd.TabIndex = 6;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(126, 108);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 7;
            btnCommit.Text = "Add";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // frmShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 149);
            Controls.Add(btnCommit);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(lblNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "frmShift";
            Text = "frmShift";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNo;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnCommit;
    }
}