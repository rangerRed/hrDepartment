using HR_Department.Core;
using System;

namespace HR_Department.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand PagesViewCommand { get; set; }

        public RelayCommand PageFrame2ViewCommand { get; set; }
        public RelayCommand PageFrame3ViewCommand { get; set; }
        public RelayCommand PageFrame4ViewCommand { get; set; }
        public RelayCommand PageFrame5ViewCommand { get; set; }

        public PagesViewModel PagesVm { get; set; }

        public PageFrame2ViewModel PageFrame2Vm { get; set; }
        public PageFrame3ViewModel PageFrame3Vm { get; set; }
        public PageFrame4ViewModel PageFrame4Vm { get; set; }
        public PageFrame5ViewModel PageFrame5Vm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            PageFrame2Vm = new PageFrame2ViewModel();
            PageFrame3Vm = new PageFrame3ViewModel();
            PageFrame4Vm = new PageFrame4ViewModel();
            PageFrame5Vm = new PageFrame5ViewModel();

            PagesVm = new PagesViewModel();
            CurrentView = PagesVm;
            PagesViewCommand = new RelayCommand(o =>
            {
                CurrentView = PagesVm;
            });
            PageFrame2ViewCommand = new RelayCommand(o =>
            {
                CurrentView = PageFrame2Vm;
            });
            PageFrame3ViewCommand = new RelayCommand(o =>
            {
                CurrentView = PageFrame3Vm;
            });
            PageFrame4ViewCommand = new RelayCommand(o =>
            {
                CurrentView = PageFrame4Vm;
            });
            PageFrame5ViewCommand = new RelayCommand(o =>
            {
                CurrentView = PageFrame5Vm;
            });

        }
    }
}
