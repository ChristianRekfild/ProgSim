using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Services;

/// <summary>
/// Сервис игры, который запускает таймер и генерит событие нового дня.
/// </summary>
internal class GameBackgroundService
{
    private NavigationStore _navigationStore;

    public GameBackgroundService(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public async Task RunTimer(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            await Task.Delay(2000);
            if (_navigationStore.CurrentViewModel is not GameSceneViewModel game) continue;

            // TODO: Убрать это все в обработчики соотв событий
            game.Protagonist.AnotherFuckingDay(); //проживаем один день

            if (game.Protagonist.IsDead())
                Application.Current.Shutdown();//если померли - закрываем приложение (НАДО ПЕРЕДЕЛАТЬ НА КРАСИВУЮ ПЛАШКУ)

            game.GameDate = game.GameDate.AddDays(1);
        }
    }
}