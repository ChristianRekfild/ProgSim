using System.Windows;
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

        public override bool CanExecute(object? parameter) => true;
        /// <summary>
        /// Действие при выполнении команды
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            SampleDialog SampleDialog = new SampleDialog();
            SampleDialog.ShowDialog();
        }
    }
}
