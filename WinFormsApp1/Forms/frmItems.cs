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
    public partial class frmItems : Form
    {
        ItemRepositroy itemRepositroy;
        public frmItems()
        {
            InitializeComponent();
            itemRepositroy = new ItemRepositroy();
            dgvItems.DataSource = itemRepositroy.GetAllItems();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int id = dgvItems.RowCount + 1;
            Form form = new frmAddItems(id);
            form.ShowDialog();
            dgvItems.DataSource = itemRepositroy.GetAllItems();
        }

        private void btnPriceChange_Click(object sender, EventArgs e)
        {
            Item selected = (Item)dgvItems.SelectedRows[0].DataBoundItem ;
            int id = selected.IdItem;
            float price = selected.Price;
            Form form = new frmChangePrice(id, price);
            form.ShowDialog();
            dgvItems.DataSource = itemRepositroy.GetAllItems();
        }
        
    }
}
