using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;
using System.IO;
using System;
using System.Text;
using System.Text.Json;
using System.Windows.Controls;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда запуска новой игры.
    /// </summary>
    internal class NavigateResumeGameCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateResumeGameCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;
        

        public override void Execute(object? parameter)
        {


             

               
                // Установка параметров главного героя при запуске новой игры.
                // Чтение из файла LastAutoSave.noob
                string jsonSaveString;
                using (StreamReader sr = new StreamReader("LastAutoSave.noob"))
                {
                    jsonSaveString = sr.ReadLine();
                }
                jsonSaveString = Encoding.UTF8.GetString(Convert.FromBase64String(jsonSaveString));//декодирование сейв файла
                Protagonist protagonist = JsonSerializer.Deserialize<Protagonist?>(jsonSaveString);

                _navigationStore.CurrentViewModel = new GameSceneViewModel(_navigationStore, protagonist);
                var gameScene = (GameSceneViewModel)_navigationStore.CurrentViewModel;
               ;
                
                
            
        }
    }
}
