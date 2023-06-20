using StockS.Logic.Items;
using StockS.Logic.User;
using StockS.Logic.WriteOff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockS.API.Forms
{
    public partial class frmWriteOff : Form
    {
        WriteOffRepository repository;
        ItemRepositroy itemrepository;
        List<Item> items;
        User currentUser;
        public frmWriteOff(User user)
        {
            InitializeComponent();
            repository = new WriteOffRepository();
            itemrepository = new ItemRepositroy();
            int num = repository.GetAllWriteOffs().Count + 1;
            lblNO.Text = num.ToString();
            currentUser = user;
            List<String> itemnames = new List<string>();
            items = itemrepository.GetAllItems();
            foreach(Item item in items)
            {
                itemnames.Add(item.Name);
            }
            cBoxItem.DataSource = itemnames;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lblNO.Text);
                string selected = cBoxItem.SelectedItem.ToString();
                int idItem = 0;
                items = itemrepository.GetAllItems();
                foreach (Item item in items)
                {
                    if (item.Name == selected) { idItem = item.IdItem; }
                }
                int quantity = int.Parse(txtQuantity.Text);
                string desc = txtDescription.Text;
                long user = currentUser.OIB;
                WriteOff document = new WriteOff(id, idItem, quantity, desc, user);
                repository = new WriteOffRepository();
                repository.AddWriteOff(document);
                MessageBox.Show("");
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }
    }
}
