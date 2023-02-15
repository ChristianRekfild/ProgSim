using System.Windows;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Handlers;

internal class ProtagonistStateHandler : IHandler
{
    private readonly NavigationStore _navigationStore;

    public ProtagonistStateHandler(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public void HandleNewDayEvent()
    {
        var game = _navigationStore.CurrentViewModel as GameSceneViewModel;

        game?.Protagonist.AnotherFuckingDay();

        if (game != null && game.Protagonist.IsDead())
            Application.Current.Shutdown();//если померли - закрываем приложение (НАДО ПЕРЕДЕЛАТЬ НА КРАСИВУЮ ПЛАШКУ)
    }
}