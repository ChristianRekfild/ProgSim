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
            var mainWindow = (Window)parameter; //берем предыдущее окно, переданное в качестве CommandParametr
            mainWindow.Effect = new System.Windows.Media.Effects.BlurEffect();//размываем предыдущее окно
            SearchWorkDialog SearchWorkDialog = new SearchWorkDialog(); //создаем объект нового диатогового окно нужного класса
            SearchWorkDialog.DataContext = _navigationStore.CurrentViewModel; //присваеваем текущую VM новому диалоговому окну
            SearchWorkDialog.ShowDialog(); //окрываем новое диатоговое окно 
            mainWindow.Effect = null; //при закрытии диалогового окна отменяем размытие предыдущего окна
        }
    }
}
