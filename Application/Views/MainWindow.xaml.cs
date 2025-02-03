using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ToolKitV.Views;

namespace ToolKitV
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, Func<UserControl>> viewFactory;

        public MainWindow()
        {
            InitializeComponent();
            LoadDefaultView();
        }

        private void LoadDefaultView()
        {
            ChangeView("TextureOptimization"); 
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public bool ChangeView(string viewName)
        {
            string typeName = $"ToolKitV.Views.{viewName}";
            try
            {
                Type viewType = Type.GetType(typeName);
                if (viewType != null && viewType.IsSubclassOf(typeof(UserControl)))
                {
                    UserControl viewInstance = (UserControl)Activator.CreateInstance(viewType);
                    MainContent.Content = viewInstance;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load view: " + ex.Message);
            }
            return false; 
        }
    }
}
