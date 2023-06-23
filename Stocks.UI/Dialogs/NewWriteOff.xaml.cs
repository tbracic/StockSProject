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
using System.Windows.Shapes;
using StockS.Logic.Items;
using StockS.Logic.WriteOff;

namespace Stocks.UI.Dialogs
{
    /// <summary>
    /// Interaction logic for NewWriteOff.xaml
    /// </summary>
    public partial class NewWriteOff : Window
    {
        public ItemRepositroy repositroy1;
        public WriteOffRepository repository;
        public NewWriteOff()
        {
            InitializeComponent();
            repositroy1 = new ItemRepositroy();
            
            ItemBox.ItemsSource = repositroy1.GetAllItemNames();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try 
            {
                repository = new WriteOffRepository();
                Item selected = (Item)ItemBox.SelectedItem;
                int id = repository.GetAllWriteOffs().Count + 1;
                WriteOff document = new WriteOff(id, selected.IdItem,int.Parse(newQuantity.Text), Descruotion.Text,11111111111);
                repository.AddWriteOff(document);
                Close();
            }
            catch { }
        }
    }
}
