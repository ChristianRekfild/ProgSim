using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {

        #region Window Title
        /// <summary>
        /// Заголовок окна
        /// </summary>
        private string _title = "Симулятор программиста: Меню";

        public string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }
        #endregion

        #region BackgroundImagePath
        /// <summary>
        /// Путь к фоновому изображению
        /// </summary>
        private string _backgroundImagePath = "/Data/Resourses/background.jpg";

        public string BackgroundImagePath
        {
            get => _backgroundImagePath;
            set => SetField(ref _backgroundImagePath, value);
        }
        #endregion

        #region LogoImagePath
        /// <summary>
        /// Путь к логотипу
        /// </summary>
        private string _logoImagePath = "/Data/Resourses/logo.jpg";

        public string LogoImagePath
        {
            get => _logoImagePath;
            set => SetField(ref _logoImagePath, value);
        }
        #endregion

        #region New Game Button
        /// <summary>
        /// Кнопка "Начать игру"
        /// </summary>
        private string _newGameButtonName = "Новая игра";

        public string NewGameButtonName
        {
            get => _newGameButtonName;
            set => SetField(ref _newGameButtonName, value);
        }

        #endregion

        #region Load Game Button
        /// <summary>
        /// Кнопка "Загрузить игру"
        /// </summary>
        private string _loadGameButtonName = "Загрузить игру";

        public string LoadGameButtonName
        {
            get => _loadGameButtonName;
            set => SetField(ref _loadGameButtonName, value);
        }

        #endregion

        #region Save Game Button
        /// <summary>
        /// Кнопка "Сохранить игру"
        /// </summary>
        private string _saveGameButtonName = "Сохранить игру";

        public string SaveGameButtonName
        {
            get => _saveGameButtonName;
            set => SetField(ref _saveGameButtonName, value);
        }

        #endregion


        #region Settings Button
        /// <summary>
        /// Кнопка "Настройки"
        /// </summary>
        private string _settingsButtonName = "Настройки";

        public string SettingsButtonName
        {
            get => _settingsButtonName;
            set => SetField(ref _settingsButtonName, value);
        }

        #endregion

        #region Feedback Button
        /// <summary>
        /// Кнопка "Обратная связь"
        /// </summary>
        private string _feedbackButtonName = "Обратная связь";

        public string FeedbackButtonName
        {
            get => _feedbackButtonName;
            set => SetField(ref _feedbackButtonName, value);
        }

        #endregion

        #region Exit Button
        /// <summary>
        /// Кнопка "Выход"
        /// </summary>
        private string _exitButtonName = "Выход";

        public string ExitButtonName
        {
            get => _exitButtonName;
            set => SetField(ref _exitButtonName, value);
        }

        #endregion

    }
}
