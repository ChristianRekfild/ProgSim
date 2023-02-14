using System.IO;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;
using System.Windows.Input;
using Noob_Coder.UserInterface;


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

        private string _title;
        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public override string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }

        private string _resumeGameButtonVisibilityStatus = "hidden";
        /// <summary>
        /// Статус кнопки продолжит игру показывать или нет.
        /// /// </summary>
        public string ResumeGameButtonVisibilityStatus
        {
            get => _resumeGameButtonVisibilityStatus;
            set => SetField(ref _resumeGameButtonVisibilityStatus, value);
        }
        
        private string _logoImagePath = "/Data/Resourses/Images/Logos.png";
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
        /// Команда-обработчик перехода на страницу продолжения игры.
        /// </summary>
        public ICommand NavigateResumeGameCommand { get; }
        /// <summary>
        /// Команда-обработчик перехода на страницу новой игры.
        /// </summary>
        public ICommand NavigateNewGameCommand { get; }
        /// <summary>
        /// Команда-обработчик перехода на страницу настроек.
        /// </summary>
        public ICommand NavigateSettingMenuCommand { get; }
        /// <summary>
        /// Команда-обработчик перехода на страницу обратной связи.
        /// </summary>
        public ICommand NavigateFeedBackFormCommand { get; }

        #endregion
        
        public MenuViewModel(NavigationStore navigationStore)
        {
            CloseApplicationCommand = new CloseApplicationCommand();
            NavigateResumeGameCommand = new NavigateResumeGameCommand(navigationStore);
            NavigateNewGameCommand = new NavigateNewGameCommand(navigationStore);
            NavigateSettingMenuCommand = new NavigateSettingMenuCommand(navigationStore);
            NavigateFeedBackFormCommand = new NavigateFeedBackFormCommand(navigationStore);
            
            Title = UI.MenuViewTitle;

            // Если существует файл LastAutoSave.noob показывать кнопу "Продолжить игру"
            if (File.Exists("LastAutoSave.noob")) ResumeGameButtonVisibilityStatus = "visable";

                    
        }
    }
}
