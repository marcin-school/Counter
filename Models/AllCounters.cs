﻿using System.ComponentModel;
using System.Windows.Input;

namespace Counter.Models
{
    public class AllCounters : INotifyPropertyChanged
    {
        public ICommand RemoveItemCommand { get; }
        public ICommand EditItemCommand { get; }
        public AllCounters() {
            RemoveItemCommand = new Command<CounterItem>(RemoveItem);
            EditItemCommand = new Command<CounterItem>(EditItem);
        }

        public List<CounterItem> Items {
            get {
                return App.Database.GetItems();
            }
        }

        private void RemoveItem(CounterItem item)
        {
            throw new NotImplementedException();
        }

        private void EditItem(CounterItem item)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
