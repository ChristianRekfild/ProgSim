using Microsoft.Extensions.DependencyInjection;
using System;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;


namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда добавления здоровья главному герою.
    /// </summary>
    internal class AddProtagonistHealthCommand : CommandBase
    {

        private NavigationStore _navigationStore;
        public AddProtagonistHealthCommand()
        {
       
        }

        /// <summary>
        /// Проверяет доступность команды для выполнения.
        /// Если метод возвращает false - команду выполнить нельзя.
        /// </summary>
        /// <param name="parameter">object</param>
        /// <returns>bool</returns>
        public override bool CanExecute(object? parameter) => true;
        /// <summary>
        /// Действие при выполнении команды
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            _navigationStore = App.Host.Services.GetRequiredService<NavigationStore>();
            if (_navigationStore.CurrentViewModel is GameSceneViewModel game)
            {
                game.Protagonist.AddHealth(Convert.ToInt32(parameter));
            }
                
        }
    }
}
