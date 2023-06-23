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
using StockS.Logic.Inventory;

namespace Stocks.UI.MWM.View
{
    /// <summary>
    /// Interaction logic for InventoryView.xaml
    /// </summary>
    public partial class InventoryView : UserControl
    {
        public InventoryRepository repository;
        public InventoryView()
        {
            InitializeComponent();
            repository = new InventoryRepository();
            dgvInventory.ItemsSource=repository.GetAllInventories();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                repository = new InventoryRepository();
                Inventory selected = (Inventory)dgvInventory.SelectedItem;
                string name = "Inventory no" + selected.IdInventory;
                repository.CreatePDFInventory(name, selected.IdInventory);
                Process.Start("explorer.exe", name + ".pdf");
            } catch { }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window= new Stocks.UI.Dialogs.NewInventory();
            window.Show();
        }
    }
}
