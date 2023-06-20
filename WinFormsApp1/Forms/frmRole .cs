using StockS.Logic.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockS.API.Forms
{
    public partial class frmRole : Form
    {
        UserRepository repositroy;
        public frmRole()
        {
            InitializeComponent();
            repositroy = new UserRepository();
            int id = repositroy.GetAllRoles().Count + 1;
            lblID.Text = id.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            repositroy = new UserRepository();

            string title = txtTitle.Text;
            int id = int.Parse(lblID.Text);
            try
            {
                repositroy.AddRole(id, title);
                MessageBox.Show("");
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }


        }
    }
}
