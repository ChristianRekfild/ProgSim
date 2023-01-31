using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда запуска новой игры.
    /// </summary>
    internal class NavigateNewGameCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateNewGameCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;
        

        public override void Execute(object? parameter)
        {

            UserSettings UserSettings = _navigationStore.CurrentViewModel.UserSettings;
            _navigationStore.CurrentViewModel = new GameSceneViewModel(_navigationStore);
            var gameScene = (GameSceneViewModel)_navigationStore.CurrentViewModel;
            gameScene.UserSettings = UserSettings;
         
                /// <summary>
                /// Установка параметров главного героя при запуске новой игры.
                /// </summary>
                gameScene.Protagonist.Health = 100; // значение здоровья главного героя игры по умолчанию
                gameScene.Protagonist.Money = 15842; // значение наличных денег по умолчанию
                gameScene.Protagonist.Mustache = 0;  // значение усатости главного героя игры по умолчанию
           
        }
    }
}
