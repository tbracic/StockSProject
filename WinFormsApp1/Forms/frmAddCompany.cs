using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using StockS.Logic.Items;
using StockS.Logic.User;

namespace StockS.API.Forms
{
    public partial class frmAddCompany : Form
    {
        ItemRepositroy repository;
        public frmAddCompany()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            
            repository = new ItemRepositroy();
            long oib = long.Parse(txtOIB.Text);
            string name = txtName.Text;
            string adress = txtAdress.Text;
            string telephone = txtPhone.Text;
            string email = txtMail.Text;
            string poruka = "Good";
            try
            {
                repository.AddNewCompany(oib, name, adress, telephone, email);
                MessageBox.Show(poruka);
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
