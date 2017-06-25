using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using MobileApp.Model;
using MobileApp.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;

namespace MobileApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            _backendService = backendService;

            Items = new ObservableCollection<Item>();
            AddItemCommand = new RelayCommand(OnItemAdd);
        }

        public string Title => "Demo App";

        public ObservableCollection<Item> Items { get; }
        string _itemName;

        public string ItemName
        {
            get
            {
                return _itemName;
            }

            set
            {
                _itemName = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand AddItemCommand { get; set; }

        private void OnItemAdd()
        {
            var newItem = new Item() { Name = this.ItemName };
            Items.Add(newItem);
            ItemName = null;
        }
    }
}
