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

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
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

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "New Item",
                SerialNumber = "xxxx",
                Quantity = 1,
            });
        }

        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }

        private void Save()
        {
            // save to file/db

        }

        private bool CanSave()
        {
            return true;
        }
    }
}
