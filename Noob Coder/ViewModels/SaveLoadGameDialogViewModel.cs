using System.Windows.Input;
using Noob_Coder.Infrastructure.Commands;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels.Base;

namespace Noob_Coder.ViewModels
{
    /// <summary>
    /// Класс модели-представления всплывающего окна загрузки/сохранения игры.
    /// Содержит свойства отображаемых во всплывающем окне загрузки/сохранения игры элементов
    /// и команды-обработчики событий.
    /// </summary>
    internal class SaveLoadGameDialogViewModel : ViewModelBase
    {

        #region Свойства

       

        #endregion

        #region Команды
        /// <summary>
        /// Команда перехода в главное меню.
        /// </summary>
        public ICommand NavigateMenuCommand { get; }

        #endregion
        public SaveLoadGameDialogViewModel(NavigationStore navigationStore, string parametr)
        {
            if (parametr == "load")
            {

            }
            else
            {

            }

            NavigateMenuCommand = new NavigateMenuCommand(navigationStore);
        }
    }
}
