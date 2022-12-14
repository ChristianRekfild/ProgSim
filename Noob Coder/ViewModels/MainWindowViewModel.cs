using System.Runtime.CompilerServices;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetField(ref _currentViewModel, value);
        }

        public MainWindowViewModel()
        {
            CurrentViewModel = new MenuViewModel();
        }
    }
}
