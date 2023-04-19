using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockS.Logic.User;

namespace StockS.API.Forms
{
    public partial class frmMenu : Form
    {
        Thread threadLogin;
        private User curentUser;
        private UserRepository repository;
        public frmMenu(User user)
        {
            InitializeComponent();
            repository = new UserRepository();
            curentUser = user;
            lblUserName.Text = curentUser.Name + " " + curentUser.Surname;
            string role = repository.GetRoleTitle(curentUser.Role);
            lblTitle.Text = role;


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            threadLogin = new Thread(OpenLogin);
            threadLogin.SetApartmentState(ApartmentState.STA);
            threadLogin.Start();
        }
        private void OpenLogin()
        {
            Application.Run(new frmLogIn());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Form form = new frmItems();
            form.ShowDialog();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            Form form = new frmAddCompany();
            form.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form form = new frmRegister();
            form.ShowDialog();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            Form form = new frmRole();
            form.ShowDialog();
        }
    }
}
