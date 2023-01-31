using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда перехода на страницу формы обратной связи.
    /// </summary>
    internal class NavigateFeedBackFormCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateFeedBackFormCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;
        

        public override void Execute(object? parameter)
        {
            UserSettings UserSettings = _navigationStore.CurrentViewModel.UserSettings;
            _navigationStore.CurrentViewModel = new FeedBackFormViewModel(_navigationStore);
            var gameScene = (FeedBackFormViewModel)_navigationStore.CurrentViewModel;
            gameScene.UserSettings = UserSettings;
        }
    }
}
