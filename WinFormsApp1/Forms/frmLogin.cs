using StockS.Logic.User;
using StockS.API.Forms;

namespace StockS
{
    public partial class frmLogIn : Form
    {
        Login login;
        User user;
        Thread threadApp;
        public frmLogIn()
        {
            InitializeComponent();
            // super admin logiranje
            txtBoxUsername.Text = "sadmin";
            txtBoxPassword.Text = "IdeGas123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = new Login();

            string username = txtBoxUsername.Text;

            string password = txtBoxPassword.Text;
            try
            {

                object messege = login.SLogIn(username, password);
                if (messege is string) { MessageBox.Show(messege.ToString()); }
                else
                {
                    user = messege as User;
                    MessageBox.Show("Dobrodasli");
                    Close();
                    threadApp = new Thread(() => OpenApp(user));
                    threadApp.ApartmentState = ApartmentState.STA;
                    threadApp.Start();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
        private void OpenApp(User user)
        {
            Application.Run(new frmMenu(user));
        }
    }
}
