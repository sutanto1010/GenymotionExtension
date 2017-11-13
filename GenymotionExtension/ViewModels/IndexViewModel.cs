using System.Collections.ObjectModel;
using GenymotionExtension.Models;

namespace GenymotionExtension.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        private bool _throttlingDisk;
        private bool _throttlingMemory;
        private bool _throttlingNetwork;
        private bool _loadingDisk;
        private bool _loadingNetwork;
        private bool _loadingMemory;
        public ObservableCollection<VirtualDevice> Devices { get; set; }

        public IndexViewModel()
        {
            Devices = new ObservableCollection<VirtualDevice>();
        }

        public bool ThrottlingDisk
        {
            get => _throttlingDisk;
            set
            {
                _throttlingDisk = value; 
                OnPropertyChanged();
            }
        }

        public bool ThrottlingMemory
        {
            get => _throttlingMemory;
            set
            {
                _throttlingMemory = value; 
                OnPropertyChanged();
            }
        }

        public bool ThrottlingNetwork
        {
            get => _throttlingNetwork;
            set
            {
                _throttlingNetwork = value; 
                OnPropertyChanged();
            }
        }

        public bool LoadingDisk
        {
            get => _loadingDisk;
            set
            {
                _loadingDisk = value; 
                OnPropertyChanged();
            }
        }

        public bool LoadingNetwork
        {
            get => _loadingNetwork;
            set
            {
                _loadingNetwork = value; 
                OnPropertyChanged();
            }
        }

        public bool LoadingMemory
        {
            get => _loadingMemory;
            set
            {
                _loadingMemory = value; 
                OnPropertyChanged();
            }
        }
    }
}
