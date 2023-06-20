using StockS.Logic.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockS.Logic.Items;

namespace StockS.API.Forms
{

    public partial class frmChangePrice : Form
    {
        ItemRepositroy repositroy;
        public frmChangePrice(int id, float price)
        {
            InitializeComponent();
            lblID.Text = id.ToString();
            lblPrice.Text = price.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            repositroy = new ItemRepositroy();
            int id = int.Parse(lblID.Text);
            float price1 = float.Parse(lblPrice.Text);
            float price2 = float.Parse(txtPrice.Text);
            try
            {
                string msg = repositroy.ChangePrice(id, price1, price2);
                MessageBox.Show(msg);
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
