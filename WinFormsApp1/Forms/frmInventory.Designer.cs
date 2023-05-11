namespace StockS.API.Forms
{
    partial class frmInventory
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
            btnPDFAllItems = new Button();
            btnAllItemsExcel = new Button();
            btnInventoryPDF = new Button();
            dgvInventory = new DataGridView();
            btnCommit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 366);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPDFAllItems
            // 
            btnPDFAllItems.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPDFAllItems.Location = new Point(12, 12);
            btnPDFAllItems.Name = "btnPDFAllItems";
            btnPDFAllItems.Size = new Size(75, 72);
            btnPDFAllItems.TabIndex = 1;
            btnPDFAllItems.Text = "Export all items to PDF";
            btnPDFAllItems.UseVisualStyleBackColor = true;
            btnPDFAllItems.Click += btnPDFAllItems_Click;
            // 
            // btnAllItemsExcel
            // 
            btnAllItemsExcel.Location = new Point(12, 168);
            btnAllItemsExcel.Name = "btnAllItemsExcel";
            btnAllItemsExcel.Size = new Size(75, 72);
            btnAllItemsExcel.TabIndex = 2;
            btnAllItemsExcel.Text = "Export all items to Excel";
            btnAllItemsExcel.UseVisualStyleBackColor = true;
            btnAllItemsExcel.Click += btnAllItemsExcel_Click;
            // 
            // btnInventoryPDF
            // 
            btnInventoryPDF.Location = new Point(12, 90);
            btnInventoryPDF.Name = "btnInventoryPDF";
            btnInventoryPDF.Size = new Size(75, 72);
            btnInventoryPDF.TabIndex = 3;
            btnInventoryPDF.Text = "Generate Invenotory PDF";
            btnInventoryPDF.UseVisualStyleBackColor = true;
            btnInventoryPDF.Click += button1_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(106, 12);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(682, 348);
            dgvInventory.TabIndex = 4;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(713, 366);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 5;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 399);
            Controls.Add(btnCommit);
            Controls.Add(dgvInventory);
            Controls.Add(btnInventoryPDF);
            Controls.Add(btnAllItemsExcel);
            Controls.Add(btnPDFAllItems);
            Controls.Add(btnClose);
            Name = "frmInventory";
            Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Button btnPDFAllItems;
        private Button btnAllItemsExcel;
        private Button btnInventoryPDF;
        private DataGridView dgvInventory;
        private Button btnCommit;
    }
}