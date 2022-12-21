using System.ComponentModel.DataAnnotations;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;
using System.Windows.Input;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления меню.
    /// Содержит свойства отображаемых на странице главного меню элементов
    /// и команды-обработчики событий. К свойствам этого класса привязана MenuView.
    /// </summary>
    internal class MenuViewModel : ViewModelBase
    {
        #region Свойства

        private string _title = "Симулятор программиста: Меню";
        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public override string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }
        private string _newGameButtonName = "Новая игра";
        /// <summary>
        /// Надпись на кнопке начала новой игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="NewGameMenuButton".
        /// </summary>
        public string NewGameButtonName
        {
            get => _newGameButtonName;
            set => SetField(ref _newGameButtonName, value);
        }
        
        private string _loadGameButtonName = "Загрузить игру";
        /// <summary>
        /// Надпись на кнопке загрузки игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="LoadGameMenuButton".
        /// </summary>
        public string LoadGameButtonName
        {
            get => _loadGameButtonName;
            set => SetField(ref _loadGameButtonName, value);
        }
        private string _saveGameButtonName = "Сохранить игру";
        /// <summary>
        /// Надпись на кнопке сохранения игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="SaveGameMenuButton".
        /// </summary>
        public string SaveGameButtonName
        {
            get => _saveGameButtonName;
            set => SetField(ref _saveGameButtonName, value);
        }

        private string _settingsButtonName = "Настройки";
        /// <summary>
        /// Надпись на кнопке перехода на страницу настроек игры.
        /// Имя привязанного элемента в разметке xaml - x:Name="NavigateSettingsMenuButton".
        /// </summary>
        public string SettingsButtonName
        {
            get => _settingsButtonName;
            set => SetField(ref _settingsButtonName, value);
        }
        private string _feedbackButtonName = "Обратная связь";
        /// <summary>
        /// Надпись на кнопке перехода на страницу обратной связи
        /// Имя привязанного элемента в разметке xaml - x:Name="NavigateFeedBackFormMenuButton".
        /// </summary>
        public string FeedbackButtonName
        {
            get => _feedbackButtonName;
            set => SetField(ref _feedbackButtonName, value);
        }
        
        private string _exitButtonName = "Выход";
        /// <summary>
        /// Надпись на кнопке закрытия приложения.
        /// Имя привязанного элемента в разметке xaml - x:Name="ExitMenuButton".
        /// </summary>
        public string ExitButtonName
        {
            get => _exitButtonName;
            set => SetField(ref _exitButtonName, value);
        }
        
        private string _backgroundImagePath = "/Data/Resourses/Images/background.jpg";
        /// <summary>
        /// Путь к фоновому изображению.
        /// </summary>
        public string BackgroundImagePath
        {
            get => _backgroundImagePath;
            set => SetField(ref _backgroundImagePath, value);
        }
        private string _logoImagePath = "/Data/Resourses/Images/logo.jpg";
        /// <summary>
        /// Путь к изображению логотипа.
        /// </summary>
        public string LogoImagePath
        {
            get => _logoImagePath;
            set => SetField(ref _logoImagePath, value);
        }
        #endregion

        #region Команды
        /// <summary>
        /// Команда-обработчик закрытия приложения.
        /// </summary>
        public ICommand CloseApplicationCommand { get; }
        /// <summary>
        /// Команда-обработчик перехода на страницу новой игры.
        /// </summary>
        public ICommand NavigateNewGameCommand { get; }
        /// <summary>
        /// Команда-обработчик перехода на страницу обратной связи.
        /// </summary>
        public ICommand NavigateFeedBackFormCommand { get; }

        #endregion
        
        public MenuViewModel(NavigationStore navigationStore)
        {
            CloseApplicationCommand = new CloseApplicationCommand();
            NavigateNewGameCommand = new NavigateNewGameCommand(navigationStore);
            NavigateFeedBackFormCommand = new NavigateFeedBackFormCommand(navigationStore);

        }
    }
}
