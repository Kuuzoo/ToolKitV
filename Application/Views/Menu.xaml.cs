using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using ToolKitV.Models;

namespace ToolKitV.Views
{
    public partial class Menu : UserControl
    {
        public ObservableCollection<NavigationMenu.Option> MenuOptions { get; set; }

        public Menu()
        {
            InitializeComponent();
            InitializeMenuOptions();
            DataContext = this;

            var listView = FindName("MenuListView") as ListView;
            if (MenuOptions.Count > 0 && listView != null)
            {
                listView.SelectedItem = MenuOptions[0];
                listView.Focus();
            }
        }

        private void InitializeMenuOptions()
        {
            MenuOptions = new ObservableCollection<NavigationMenu.Option>
            {
                new NavigationMenu.Option { Name = "Texture Optimizer", IconPath = "../Assets/Images/textureIcon.png", ViewName = "TextureOptimization", Enabled = true },
                new NavigationMenu.Option { Name = "RPF Unpacker", IconPath = "../Assets/Images/vehiclesIcon.png", ViewName = "RPFUnpacker", Enabled = true },
                new NavigationMenu.Option { Name = "Clothes", IconPath = "../Assets/Images/clothesIcon.png", ViewName = "Clothes", Enabled = false }
            };
        }

        private void Menu_Select(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListView lv && lv.SelectedItem is NavigationMenu.Option menuItem)
            {
                var mainWindow = Application.Current.MainWindow as MainWindow;
                bool viewChanged = mainWindow?.ChangeView(menuItem.ViewName) ?? false;
                if (!viewChanged)
                {
                    lv.SelectedItem = e.RemovedItems.Count > 0 ? e.RemovedItems[0] : lv.SelectedItem;
                }
            }
        }
    }
}
