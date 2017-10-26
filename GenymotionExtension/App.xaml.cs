using System.Windows;
using GenymotionExtension.Views;

namespace GenymotionExtension
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = Index.Current;
            MainWindow.Show();
        }
    }
}
