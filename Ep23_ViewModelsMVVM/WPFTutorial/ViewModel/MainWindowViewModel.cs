using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPFTutorial.Model;
using WPFTutorial.MVVM;

namespace WPFTutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainWindowViewModel() 
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "Product1",
                SerialNumber = "0001",
                Quantity = 5
            });
            Items.Add(new Item
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 5
            });
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

    }
}
