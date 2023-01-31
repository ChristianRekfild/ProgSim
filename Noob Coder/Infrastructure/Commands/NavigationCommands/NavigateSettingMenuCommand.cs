using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда перехода на страницу настроек.
    /// </summary>
    internal class NavigateSettingMenuCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateSettingMenuCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;
        

        public override void Execute(object? parameter)
        {
            UserSettings UserSettings = _navigationStore.CurrentViewModel.UserSettings;
            _navigationStore.CurrentViewModel = new SettingMenuViewModel(_navigationStore);
            var gameScene = (SettingMenuViewModel)_navigationStore.CurrentViewModel;
            gameScene.UserSettings = UserSettings;
        }
    }
}
