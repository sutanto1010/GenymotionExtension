using System.Collections.ObjectModel;
using System.Windows.Input;
using GenymotionExtension.Models;
using Syncfusion.Windows.Shared;

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
        private double _limitDisk;
        private double _limitMemory;
        private double _limitNework;
        public ICommand CmdThrottlingDisk { get; set; }
        public ICommand CmdThrottlingMemory { get; set; }
        public ICommand CmdThrottlingNetwork { get; set; }
        public ObservableCollection<VirtualDevice> Devices { get; set; }

        public IndexViewModel()
        {
            Devices = new ObservableCollection<VirtualDevice>();
            CmdThrottlingDisk = new DelegateCommand(ApplyThrottlingDisk, (i)=> true);
        }

        public double LimitDisk
        {
            get => _limitDisk;
            set
            {
                _limitDisk = value; 
                OnPropertyChanged();
            }
        }

        public double LimitMemory
        {
            get => _limitMemory;
            set
            {
                _limitMemory = value; 
                OnPropertyChanged();
            }
        }

        public double LimitNework
        {
            get { return _limitNework; }
            set
            {
                _limitNework = value; 
                OnPropertyChanged();
            }
        }

        private void ApplyThrottlingDisk(object obj)
        {
            
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
