using Noob_Coder.Infrastructure.Commands.Base;
using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Services;
using System.Windows;
using Noob_Coder.Models;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.ViewModels;
using System;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда сохранения игры.
    /// </summary>
    internal class SaveGameCommand : CommandBase
    {

        private NavigationStore _navigationStore;
        public SaveGameCommand()
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
            string fileName = (string)parameter;

            _navigationStore = App.Host.Services.GetRequiredService<NavigationStore>();
            if (_navigationStore.CurrentViewModel is GameSceneViewModel game)
            {
                GameSaveModel gameSaveModel = new GameSaveModel(game.Protagonist, game.GameSettings);
                gameSaveModel.Save(fileName+".noob");
            }


        }
    }
}
