using StockS.Logic.Items;
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
using StockS.Logic.Items;

namespace Stocks.UI.MWM.View
{
    /// <summary>
    /// Interaction logic for ItemView.xaml
    /// </summary>
    public partial class ItemView : UserControl
    {
        public ItemRepositroy repositroy;
        public ItemView()
        {
            InitializeComponent();
            repositroy = new ItemRepositroy();
            List<Item> items = repositroy.GetAllItems();
            dgvItems.ItemsSource = items;
            
        }

    }
}
