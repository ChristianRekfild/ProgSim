using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Handlers;

internal class GameSettingsHandler : IHandler
{
    private readonly NavigationStore _navigationStore;

    public GameSettingsHandler(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public void HandleNewDayEvent()
    {
        if (_navigationStore.CurrentViewModel is GameSceneViewModel game)
            game.GameSettings.CurrentDate = game.GameSettings.CurrentDate.AddDays(1);
    }
}