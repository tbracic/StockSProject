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
    public partial class frmRegister : Form
    {
        List<Role> roles;
        UserRepository repository;
        public frmRegister()
        {
            InitializeComponent();
            repository = new UserRepository();
            List<String> titles = new List<string>();
            roles = repository.GetAllRoles();
            int i = 0;
            foreach (Role role in roles)
            {
                titles.Add(role.Title.ToString());
            }
            cBoxRoles.DataSource = titles;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            string msg = "";
            long oib = long.Parse(txtOIB.Text);
            string name = txtName.Text;
            string surr = txtSurrname.Text;
            string adress = txtAdress.Text;
            string telephone = txtPhone.Text;
            string mail = txtMail.Text;
            string selected = cBoxRoles.SelectedText;
            string pass = txtPassword.Text;
            int id = 3;
            foreach (Role role in roles)
            {
                if (role.Title == selected) { id = role.IdRole; break; }
            }
            try
            {
                repository.AddUser(oib, name, surr, adress, mail, telephone, id, pass);
                MessageBox.Show(msg);
                Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
