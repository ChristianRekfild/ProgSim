using System;
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


            if (game.GameSettings.CurrentDate != game.Protagonist.LastSellaryDay)
            {
            foreach (int day in game.Protagonist.CurrentWork.PayDay)
                {
                if (day == Convert.ToInt32(game.GameSettings.CurrentDate.Day))
                    {
                    game.Protagonist.GetSellary(game.Protagonist.LastSellaryDay, game.GameSettings.CurrentDate);
                    }
                }
            }

        

        if (game != null && game.Protagonist.IsDead()) 
        { 
            MessageBox.Show("Поздравляю, Вы успешно померли");
            Application.Current.Shutdown();//если померли - закрываем приложение (НАДО ПЕРЕДЕЛАТЬ НА более КРАСИВУЮ ПЛАШКУ)
        }
    }
}