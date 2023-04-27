﻿using StockS.Logic.Inventory;
using StockS.Logic.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockS.API.Forms
{
    public partial class frmInventory : Form
    {
        InventoryRepository repository;
        public frmInventory(User user)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPDFAllItems_Click(object sender, EventArgs e)
        {
            repository = new InventoryRepository();
            string filename = "ItemList";
            string msg = repository.CreatepdfFile(filename);
            MessageBox.Show(msg);
            Process.Start("explorer.exe",filename + ".pdf");
        }
    }
}
