using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;
using System;
using System.Text;
using System.IO;
using System.Text.Json;


namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда запуска новой игры.
    /// </summary>
    internal class NavigateNewGameCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateNewGameCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;
        

        public override void Execute(object? parameter)
        {
            Protagonist protagonist;
            GameSettings gameSettings;
            
            string saveFileName = (string)parameter;
            if (saveFileName.Substring(saveFileName.Length - 5) == ".noob")
            {
                GameSaveModel gameSaveModel = new GameSaveModel();
                gameSaveModel = gameSaveModel.Load(saveFileName);
                protagonist = gameSaveModel.Protagonist;
                gameSettings = gameSaveModel.GameSettings;
            }
            else
            {
                gameSettings = new GameSettings();
                protagonist = new Protagonist();
                protagonist.Health = 100; // значение здоровья главного героя игры по умолчанию
                protagonist.Stamina = 100; //значение усталости главного героя игры по умолчанию
                protagonist.Appearance = 50; //значение опрятности главного героя игры по умолчанию
                protagonist.Mood = 50;  // значение настроения главного героя игры по умолчанию
                protagonist.Money = 15842; // значение наличных денег по умолчанию
                protagonist.CurrentWork = new Work(new EmptyJob(), new EmptyCompany());
            }


            _navigationStore.CurrentViewModel = ActivatorUtilities.CreateInstance<GameSceneViewModel>(App.Host.Services, protagonist, gameSettings);



        }
    }
}
