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
    public partial class frmMain : Form
    {
        Thread threadLogin;
        public frmMain(User user)
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            dataGridView1.Hide();
        }
        private void OpenLogin()
        {
            Application.Run(new frmLogIn());
        }
        private void btnDGV_Click(object sender, EventArgs e)
        {
            ClearAll();
            dataGridView1.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
            threadLogin = new Thread(OpenLogin);
            threadLogin.SetApartmentState(ApartmentState.STA);
            threadLogin.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
