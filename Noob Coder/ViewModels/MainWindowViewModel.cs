using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления главного окна.
    /// Содержит свойства главного окна, не привязанные к представлениям.
    /// </summary>
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private ViewModelBase _currentViewModel;
        /// <summary>
        /// Активная модель-представление. Взависимости от значения этого свойства в главном окне рендерятся разные представления.
        /// </summary>
        public ViewModelBase CurrentViewModel
        {
            get => _navigationStore.CurrentViewModel;
            set => SetField(ref _currentViewModel, value);
        }

        private string _title;
        /// <summary>
        /// Имя заголовка окна приложения. Имя заголовка подставляется из этого свойства,
        /// а берётся из конкретной модели-представления
        /// при срабатывании события OnCurrentViewModelChanged().
        /// </summary>
        public override string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }
        public MainWindowViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            Title = _navigationStore.CurrentViewModel.Title;
        }
        /// <summary>
        /// Событие смены модели-представления окна приложения.
        /// </summary>
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
            Title = _navigationStore.CurrentViewModel.Title;
        }
    }
}
