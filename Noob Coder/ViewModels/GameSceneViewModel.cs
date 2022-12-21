using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления основного окна игры.
    /// </summary>
    internal class GameSceneViewModel : ViewModelBase
    {

        #region Свойства

        private string _title = "Симулятор программиста.";
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


        #endregion
        public GameSceneViewModel(NavigationStore navigationStore)
        {
            
        }
    }
}
