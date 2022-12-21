using System;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.Infrastructure.Stores
{
    /// <summary>
    /// Хранит информацию о том, какая модель-представление сейчас активна в главном окне приложения.
    /// </summary>
    internal class NavigationStore
    {
        public event Action CurrentViewModelChanged;
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }
        /// <summary>
        /// Оповещает о том, что изменилось текущая модель-представление главного окна.
        /// На это событие подписана модель-представление главного окна MainWindowViewModel.
        /// </summary>
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
