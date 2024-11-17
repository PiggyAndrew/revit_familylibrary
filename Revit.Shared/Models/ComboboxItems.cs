using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Revit.Shared.Models
{
    public class ComboboxItems<T> : ObservableObject
    {
        public ComboboxItems() { }

        public T SelectedItem { get; set; }

        private ObservableCollection<T> _items = new ObservableCollection<T>();

        public ObservableCollection<T> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
    }
}
