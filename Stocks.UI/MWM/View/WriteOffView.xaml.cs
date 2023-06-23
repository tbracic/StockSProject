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
using StockS.Logic.WriteOff;
namespace Stocks.UI.MWM.View
{
    /// <summary>
    /// Interaction logic for WriteOffView.xaml
    /// </summary>
    public partial class WriteOffView : UserControl
    {
        public WriteOffRepository repository;
        public WriteOffView()
        {
            InitializeComponent();
            repository = new WriteOffRepository();
            List<WriteOff> writeOffs = repository.GetAllWriteOffs();
            dgvWriteOff.ItemsSource = writeOffs;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Stocks.UI.Dialogs.NewWriteOff();
            window.Show();
        }

    }
}
