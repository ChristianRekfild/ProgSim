using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.UserInterface;
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

        public ObservableCollection<string> Languages { get; set; } //коллекция доступных языков

        /// <summary>
        /// Выбора языка.
        /// </summary>
        private string _selectedLanguage;
        public string SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                SetField(ref _selectedLanguage, value);
                switch (_selectedLanguage)
                {
                    case "Русский":
                        RusUI.ChangeUI();
                        break;
                    case "English":
                        EngUI.ChangeUI();
                        break;
                }
            }
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
           // RUI.ChangeUI();
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
            Languages = new ObservableCollection<string> { "Русский", "English"};
            
        }
    }
}
