﻿namespace StockS.API.Forms
{
    partial class frmConclusion
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
            dTPdate = new DateTimePicker();
            cBoxShift = new ComboBox();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnCommit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dTPdate
            // 
            dTPdate.Location = new Point(316, 12);
            dTPdate.Name = "dTPdate";
            dTPdate.Size = new Size(200, 23);
            dTPdate.TabIndex = 0;
            // 
            // cBoxShift
            // 
            cBoxShift.FormattingEnabled = true;
            cBoxShift.Location = new Point(439, 41);
            cBoxShift.Name = "cBoxShift";
            cBoxShift.Size = new Size(77, 23);
            cBoxShift.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(421, 351);
            dataGridView1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 432);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(441, 432);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 4;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            // 
            // frmConclusion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 467);
            Controls.Add(btnCommit);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(cBoxShift);
            Controls.Add(dTPdate);
            Name = "frmConclusion";
            Text = "frmConclusion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dTPdate;
        private ComboBox cBoxShift;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Button btnCommit;
    }
}