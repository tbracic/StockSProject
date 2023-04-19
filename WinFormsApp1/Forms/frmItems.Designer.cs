namespace StockS.API.Forms
{
    partial class frmItems
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
            dgvItems = new DataGridView();
            btnAddItem = new Button();
            btnBack = new Button();
            btnPriceChange = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(12, 12);
            dgvItems.Name = "dgvItems";
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(776, 387);
            dgvItems.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(12, 415);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(113, 23);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add New Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(713, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPriceChange
            // 
            btnPriceChange.Location = new Point(131, 415);
            btnPriceChange.Name = "btnPriceChange";
            btnPriceChange.Size = new Size(129, 23);
            btnPriceChange.TabIndex = 3;
            btnPriceChange.Text = "Change price";
            btnPriceChange.UseVisualStyleBackColor = true;
            btnPriceChange.Click += btnPriceChange_Click;
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPriceChange);
            Controls.Add(btnBack);
            Controls.Add(btnAddItem);
            Controls.Add(dgvItems);
            Name = "frmItems";
            Text = "frmItems";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItems;
        private Button btnAddItem;
        private Button btnBack;
        private Button btnPriceChange;
    }
}