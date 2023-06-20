using Stocks.UI.Core;
using Stocks.UI.MWM.View;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Stocks.UI.MWM.ViewModel
{
    class MainViewModel:ObservableObject
    {
        public RelayCommand ItemViewCommand { get; set; }
        public RelayCommand ConclusionViewCommand { get; set; }
        public RelayCommand InventoryViewCommand { get; set; }
        public RelayCommand ReceiptViewCommand { get; set; }
        public RelayCommand WriteOffCommand { get; set; }

        public ItemViewModel ItemVM { get; set; }
        public ConclusionViewModel ConclusionVM { get;set; }
        public InventoryViewModel InventoryVM { get; set; }
        public ReceiptViewModel ReceiptVM { get; set; }
        public WriteOffViewModel WriteOffVM { get; set; }
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            ItemVM = new ItemViewModel();
            ConclusionVM = new ConclusionViewModel();
            InventoryVM = new InventoryViewModel();
            ReceiptVM = new ReceiptViewModel();
            WriteOffVM = new WriteOffViewModel();

            CurrentView = ItemVM;

            ItemViewCommand = new RelayCommand(o =>
            {
                CurrentView = ItemVM;
            });
            ConclusionViewCommand = new RelayCommand(o =>
            {
                CurrentView = ConclusionVM;
            });
            InventoryViewCommand = new RelayCommand(o =>
            {
                CurrentView = InventoryVM;
            });
            ReceiptViewCommand = new RelayCommand(o =>
            {
                CurrentView = ReceiptVM;
            });
            WriteOffCommand = new RelayCommand(o =>
            {
                CurrentView = WriteOffVM;
            });
        }
    }
}
