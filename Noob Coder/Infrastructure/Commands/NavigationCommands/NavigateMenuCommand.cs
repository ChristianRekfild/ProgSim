using System.Threading;
using System.Text.Json;
using Noob_Coder.Models;
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
            if (_navigationStore.CurrentViewModel is GameSceneViewModel ClosingGameScene)
            {
                /// <summary>
                /// Заверение работы таймера.
                /// </summary>
                ClosingGameScene.CancelTimer();
                
                /// <summary>
                /// Автосохранение параметров главного героя в файл LastAutoSave.noob в формате JSON.
                /// </summary>
                string jsonSaveString = JsonSerializer.Serialize(ClosingGameScene.Protagonist);
                using (StreamWriter sw = new StreamWriter("LastAutoSave.noob"))
                {
                    sw.WriteLine(jsonSaveString);
                }
              
            }
            if (_navigationStore.CurrentViewModel is SettingMenuViewModel ClosingSettingMenu)
            {
                /// <summary>
                /// Автосохранение параметров пользовательских настроек в файл settings.noob в формате JSON.
                /// </summary>
                string jsonSaveString = JsonSerializer.Serialize(ClosingSettingMenu.UserSettings);
                using (StreamWriter sw = new StreamWriter("settings.noob"))
                {
                    sw.WriteLine(jsonSaveString);
                }

            }    

                UserSettings UserSettings = _navigationStore.CurrentViewModel.UserSettings;

            _navigationStore.CurrentViewModel = new MenuViewModel(_navigationStore);
            var gameScene = (MenuViewModel)_navigationStore.CurrentViewModel;
            gameScene.UserSettings = UserSettings;
        }
    }
}
