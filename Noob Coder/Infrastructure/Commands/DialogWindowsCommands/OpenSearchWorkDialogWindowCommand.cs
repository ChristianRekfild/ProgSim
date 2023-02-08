using System.Windows;
using System.Windows.Media;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels;
using Noob_Coder.Views;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда открытия всплывающего окна.
    /// </summary>
    internal class OpenSearchWorkDialogWindowCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public OpenSearchWorkDialogWindowCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;
        /// <summary>
        /// Действие при выполнении команды
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            var mainWindow = (Window)parameter;
            mainWindow.Effect = new System.Windows.Media.Effects.BlurEffect();
            SearchWorkDialog SearchWorkDialog = new SearchWorkDialog();
            SearchWorkDialog.DataContext = _navigationStore.CurrentViewModel;
            SearchWorkDialog.ShowDialog();
            mainWindow.Effect = null;
        }
    }
}
