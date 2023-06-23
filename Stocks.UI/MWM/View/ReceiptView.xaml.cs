using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using StockS.Logic.Receipt;
namespace Stocks.UI.MWM.View
{
    /// <summary>
    /// Interaction logic for WriteOffView.xaml
    /// </summary>
    public partial class ReceiptView : UserControl
    {
        public ReceiptRepository repository;
        public ReceiptView()
        {
            InitializeComponent();
            repository = new ReceiptRepository();
            dgvReceipt.ItemsSource = repository.GetAllReceipts();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Receipt selected = (Receipt)dgvReceipt.SelectedItem;
                string name = "Receipt no." + selected.Id;
                repository.CreatePDFReceipt(name, selected.Id);
                Process.Start("explorer.exe", name + ".pdf");
            } catch { }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window window = new Stocks.UI.Dialogs.NewReceipt();
            window.Show();
        }
    }
}
