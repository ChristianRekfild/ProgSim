using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления страницы настроек.
    /// Содержит свойства отображаемых на странице настроек элементов
    /// и команды-обработчики событий. К свойствам этого класса привязана SettingMenuView.
    /// </summary>
    internal class SettingMenuViewModel : ViewModelBase
    {

        #region Свойства

        private string _title = "Симулятор программиста: Настройки";
        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public override string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }
        
        #endregion

        #region Команды
        /// <summary>
        /// Команда перехода в главное меню.
        /// </summary>
        public ICommand NavigateMenuCommand { get; }

        #endregion
        public SettingMenuViewModel(NavigationStore navigationStore)
        {
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
        }
    }
}
