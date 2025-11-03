using System.Windows;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace VoidstrapMVP.Views
{
    public partial class MainWindow : FluentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // Apply system theme on startup
            SystemThemeWatcher.Watch(this);
        }

        private void SetDarkTheme(object sender, RoutedEventArgs e)
        {
            ApplicationThemeManager.Apply(ApplicationTheme.Dark);
            StatusText.Text = "Dark theme applied";
        }

        private void SetLightTheme(object sender, RoutedEventArgs e)
        {
            ApplicationThemeManager.Apply(ApplicationTheme.Light);
            StatusText.Text = "Light theme applied";
        }
    }
}