using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StockS.Logic.Inventory;
using StockS.Logic.Conclusion;

using StockS.Logic.User;
using StockS.API.Forms;
using System.Windows.Forms;
using Stocks.UI.Dialogs;

namespace Stocks.UI.MWM.View
{
    /// <summary>
    /// Interaction logic for ConclusionView.xaml
    /// </summary>
    public partial class ConclusionView : System.Windows.Controls.UserControl
    {
        public ConclusionRepositroy repository;
        public ConclusionView()
        {
            InitializeComponent();
            repository 
                = new ConclusionRepositroy();
            dgvInventory.ItemsSource = repository.GetAllConclusions();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserRepository repo2 = new UserRepository();
            User user = repo2.GetUser("Admin");
            Window window = new NewConclusion();
            window.Show();
        }
    }
}
