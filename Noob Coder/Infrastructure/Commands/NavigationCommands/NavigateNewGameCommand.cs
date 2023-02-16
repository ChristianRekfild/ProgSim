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
            switch ((string)parameter)
            {
                case "resume":
                    string jsonSaveString;
                    using (StreamReader sr = new StreamReader("LastAutoSave.noob"))
                    {
                        jsonSaveString = sr.ReadLine();
                    }
                    jsonSaveString = Encoding.UTF8.GetString(Convert.FromBase64String(jsonSaveString));//декодирование сейв файла
                    protagonist = JsonSerializer.Deserialize<Protagonist?>(jsonSaveString);
                    break;

                default:
                    protagonist = new Protagonist();
                    protagonist.Health = 100; // значение здоровья главного героя игры по умолчанию
                    protagonist.Stamina = 100; //значение усталости главного героя игры по умолчанию
                    protagonist.Appearance = 50; //значение опрятности главного героя игры по умолчанию
                    protagonist.Mood = 50;  // значение настроения главного героя игры по умолчанию
                    protagonist.Money = 15842; // значение наличных денег по умолчанию
                    protagonist.CurrentWork = new Work(new EmptyJob(), new EmptyCompany());
                    break;

            }

            _navigationStore.CurrentViewModel = ActivatorUtilities.CreateInstance<GameSceneViewModel>(App.Host.Services, protagonist);



        }
    }
}
