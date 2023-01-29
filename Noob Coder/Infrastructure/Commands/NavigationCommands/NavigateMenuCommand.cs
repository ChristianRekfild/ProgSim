using System.Threading;
using System.Text.Json;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels;
using System.IO;
using System.Windows.Controls;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда перехода на страницу главного меню.
    /// </summary>
    internal class NavigateMenuCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateMenuCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            if (_navigationStore.CurrentViewModel is GameSceneViewModel gameScene)
            {
                /// <summary>
                /// Заверение работы таймера.
                /// </summary>
                gameScene.CancelTimer();
                
                /// <summary>
                /// Автосохранение параметров главного героя в файл LastAutoSave.noob в формате JSON.
                /// </summary>
                string jsonSaveString = JsonSerializer.Serialize(gameScene.Protagonist);
                using (StreamWriter sw = new StreamWriter("LastAutoSave.noob"))
                {
                    sw.WriteLine(jsonSaveString);
                }
              
            }


            _navigationStore.CurrentViewModel = new MenuViewModel(_navigationStore);
        }
    }
}
