using StockS.Logic.User;
using StockS.API.Forms;

namespace StockS
{
    public partial class frmLogIn : Form
    {
        Login login;
        User user;
        Thread  threadApp;
        public frmLogIn()
        {
            InitializeComponent();
            // super admin logiranje
            txtBoxUsername.Text = "11111111111";
            txtBoxPassword.Text = "IdeGas123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = new Login();
            
            string oib = txtBoxUsername.Text;
            
            string password = txtBoxPassword.Text;
            object messege = login.SLogIn(oib, password);
            if(messege is string) { MessageBox.Show(messege.ToString()); }
            else 
            {
                user = messege as User;
                MessageBox.Show("Dobrodasli");
                Close();
                threadApp = new Thread(()=>OpenApp(user));
                threadApp.ApartmentState = ApartmentState.STA;
                threadApp.Start();
            }
        }
        private void OpenApp(User user)
        {
            Application.Run(new frmMenu(user));
        }
    }
}
