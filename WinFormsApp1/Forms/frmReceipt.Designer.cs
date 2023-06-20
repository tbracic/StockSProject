namespace StockS.API.Forms
{
    partial class frmReceipt
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
            dgvBoughtItems = new DataGridView();
            dgvItem = new DataGridViewComboBoxColumn();
            dgvQuantity = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            btnCLose = new Button();
            btnCommit = new Button();
            cBoxCompany = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBoughtItems).BeginInit();
            SuspendLayout();
            // 
            // dgvBoughtItems
            // 
            dgvBoughtItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoughtItems.Columns.AddRange(new DataGridViewColumn[] { dgvItem, dgvQuantity, dgvPrice });
            dgvBoughtItems.Location = new Point(12, 12);
            dgvBoughtItems.Name = "dgvBoughtItems";
            dgvBoughtItems.RowTemplate.Height = 25;
            dgvBoughtItems.Size = new Size(343, 370);
            dgvBoughtItems.TabIndex = 0;
            // 
            // dgvItem
            // 
            dgvItem.HeaderText = "Item";
            dgvItem.Name = "dgvItem";
            dgvItem.Resizable = DataGridViewTriState.True;
            dgvItem.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dgvQuantity
            // 
            dgvQuantity.HeaderText = "Quantity";
            dgvQuantity.Name = "dgvQuantity";
            // 
            // dgvPrice
            // 
            dgvPrice.HeaderText = "Purchuese price";
            dgvPrice.Name = "dgvPrice";
            // 
            // btnCLose
            // 
            btnCLose.Location = new Point(12, 415);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(75, 23);
            btnCLose.TabIndex = 1;
            btnCLose.Text = "Back";
            btnCLose.UseVisualStyleBackColor = true;
            btnCLose.Click += btnCLose_Click;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(368, 415);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 2;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // cBoxCompany
            // 
            cBoxCompany.FormattingEnabled = true;
            cBoxCompany.Location = new Point(368, 12);
            cBoxCompany.Name = "cBoxCompany";
            cBoxCompany.Size = new Size(121, 23);
            cBoxCompany.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(255, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Create PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(button1);
            Controls.Add(cBoxCompany);
            Controls.Add(btnCommit);
            Controls.Add(btnCLose);
            Controls.Add(dgvBoughtItems);
            Name = "frmReceipt";
            Text = "frmReceipt";
            ((System.ComponentModel.ISupportInitialize)dgvBoughtItems).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dgvBoughtItems;
        private Button btnCLose;
        private Button btnCommit;
        private DataGridViewComboBoxColumn dgvItem;
        private DataGridViewTextBoxColumn dgvQuantity;
        private DataGridViewTextBoxColumn dgvPrice;
        private ComboBox cBoxCompany;
        private Button button1;
    }
}