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
    internal class OpenSampleDialogWindowCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public OpenSampleDialogWindowCommand(NavigationStore navigationStore)
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
            SampleDialog SampleDialog = new SampleDialog();
            SampleDialog.DataContext = _navigationStore.CurrentViewModel;
            SampleDialog.ShowDialog();
            mainWindow.Effect = null;
        При}
    }
}
