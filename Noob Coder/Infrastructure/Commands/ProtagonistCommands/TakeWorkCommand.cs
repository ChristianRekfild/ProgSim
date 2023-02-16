using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;


namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда, позволяющая взять работу.
    /// </summary>
    internal class TakeWorkCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        public TakeWorkCommand()
        {
            
        }
        /// <summary>
        /// Проверяет доступность команды для выполнения.
        /// Если метод возвращает false - команду выполнить нельзя.
        /// </summary>
        /// <param name="parameter">object</param>
        /// <returns>bool</returns>
        public override bool CanExecute(object? parameter) => parameter is Work;
        /// <summary>
        /// Действие при выполнении команды
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            _navigationStore = App.Host.Services.GetRequiredService<NavigationStore>();
            if (_navigationStore.CurrentViewModel is GameSceneViewModel game) 
            {
                Protagonist protagonist = game.Protagonist;
                GameSettings gameSettings = game.GameSettings;
                protagonist.CurrentWork = (Work) parameter;
                protagonist.EmploymentDate = gameSettings.CurrentDate;
                protagonist.LastSellaryDay = gameSettings.CurrentDate;

            }

        }
    }
}
