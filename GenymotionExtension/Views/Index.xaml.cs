using System;
using System.Windows.Forms;
using GenymotionExtension.ViewModels;

namespace GenymotionExtension.Views
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index 
    {
        private static Index _instance;
        public IndexViewModel Model => DataContext as IndexViewModel;
        public static Index Current => _instance ?? (_instance = new Index());

        private Index()
        {
            InitializeComponent();
            DataContext = new IndexViewModel();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            var devices = VBoxHelper.GetVirtualDevices();
            foreach (var virtualDevice in devices)
            {
                Model.Devices.Add(virtualDevice);
            }
        }
    }
}
