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
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 415);
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
            btnPDFAllItems.Location = new Point(93, 12);
            btnPDFAllItems.Name = "btnPDFAllItems";
            btnPDFAllItems.Size = new Size(75, 72);
            btnPDFAllItems.TabIndex = 1;
            btnPDFAllItems.Text = "Export all items to PDF";
            btnPDFAllItems.UseVisualStyleBackColor = true;
            btnPDFAllItems.Click += btnPDFAllItems_Click;
            // 
            // btnAllItemsExcel
            // 
            btnAllItemsExcel.Location = new Point(12, 12);
            btnAllItemsExcel.Name = "btnAllItemsExcel";
            btnAllItemsExcel.Size = new Size(75, 72);
            btnAllItemsExcel.TabIndex = 2;
            btnAllItemsExcel.Text = "Export all items to Excel";
            btnAllItemsExcel.UseVisualStyleBackColor = true;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAllItemsExcel);
            Controls.Add(btnPDFAllItems);
            Controls.Add(btnClose);
            Name = "frmInventory";
            Text = "frmInventory";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Button btnPDFAllItems;
        private Button btnAllItemsExcel;
    }
}