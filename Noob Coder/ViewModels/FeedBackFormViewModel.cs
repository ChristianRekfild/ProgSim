using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления формы обратной связи.
    /// Содержит свойства отображаемых на странице формы обратной связи элементов
    /// и команды-обработчики событий. К свойствам этого класса привязана FeedBackFormView.
    /// </summary>
    internal class FeedBackFormViewModel : ViewModelBase
    {

        #region Свойства

        private string _title = "Симулятор программиста: Обратная связь";
        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public override string Title
        {
            get => _title;
            set => SetField(ref _title, value);
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

        #endregion

        #region Команды
        /// <summary>
        /// Команда перехода в главное меню.
        /// </summary>
        public ICommand NavigateMenuCommand { get; }

        #endregion
        public FeedBackFormViewModel(NavigationStore navigationStore)
        {
            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
        }
    }
}
