namespace StockS.API.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pictureBox1 = new PictureBox();
            layoutPanel = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDGV = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // layoutPanel
            // 
            layoutPanel.ColumnCount = 2;
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            layoutPanel.Controls.Add(pictureBox1, 0, 0);
            layoutPanel.Controls.Add(dataGridView1, 1, 1);
            layoutPanel.Controls.Add(flowLayoutPanel1, 0, 1);
            layoutPanel.Controls.Add(flowLayoutPanel2, 0, 2);
            layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.Location = new Point(0, 0);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.RowCount = 3;
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84F));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            layoutPanel.Size = new Size(837, 485);
            layoutPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(128, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(706, 401);
            dataGridView1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDGV);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(119, 401);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnDGV
            // 
            btnDGV.Location = new Point(3, 3);
            btnDGV.Name = "btnDGV";
            btnDGV.Size = new Size(109, 23);
            btnDGV.TabIndex = 0;
            btnDGV.Text = "Data grid";
            btnDGV.UseVisualStyleBackColor = true;
            btnDGV.Click += btnDGV_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnLogOut);
            flowLayoutPanel2.Location = new Point(3, 458);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(119, 24);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(3, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(112, 23);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(837, 485);
            Controls.Add(layoutPanel);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            layoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TableLayoutPanel layoutPanel;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDGV;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnLogOut;
    }
}