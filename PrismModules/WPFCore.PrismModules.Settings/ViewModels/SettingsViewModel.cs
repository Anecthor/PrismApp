using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WPFCore.Business;

namespace WPFCore.PrismModules.Settings.ViewModels
{
    public class SettingsViewModel : BindableBase
    {

        private ObservableCollection<NavigationItem> _items;

        public ObservableCollection<NavigationItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public SettingsViewModel()
        {
            GenerateSettings();
        }

        private void GenerateSettings()
        {
            Items = new ObservableCollection<NavigationItem>();
            var root = new NavigationItem() {Caption = "Settings", NavigationPath = "SettingsList"};
            
            root.Items.Add( new NavigationItem(){ Caption = "IP Address", NavigationPath = ""});
            root.Items.Add(new NavigationItem() { Caption = "Port", NavigationPath = "" });
            root.Items.Add(new NavigationItem() { Caption = "Station Name", NavigationPath = "" });


            Items.Add(root);
        }
    }
}
