using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Stores;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _navigationStore.CurrentViewModel;
            set => SetField(ref _currentViewModel, value);
        }
        private string _title;
        public string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }
        public ICommand NavigateFeedBackFormCommand { get; }
        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            NavigateFeedBackFormCommand = new NavigateFeedBackFormCommand(navigationStore);
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
