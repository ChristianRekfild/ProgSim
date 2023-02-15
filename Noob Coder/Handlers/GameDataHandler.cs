using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Handlers;

internal class GameDataHandler : IHandler
{
    private readonly NavigationStore _navigationStore;

    public GameDataHandler(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public void HandleNewDayEvent()
    {
        if (_navigationStore.CurrentViewModel is GameSceneViewModel game)
            game.GameDate = game.GameDate.AddDays(1);
    }
}