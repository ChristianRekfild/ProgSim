using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Noob_Coder.Infrastructure.Stores;
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
    private int _speed = 2000;
        
    public delegate void EventContainer();

    public event EventContainer? DayChanged;

    public async Task RunTimer(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            await Task.Delay(_speed);
            if (_navigationStore.CurrentViewModel is not GameSceneViewModel game) continue;

            DayChanged?.Invoke();
        }
    }

    public void ChangeSpeed(int speed) { _speed = speed; }

}