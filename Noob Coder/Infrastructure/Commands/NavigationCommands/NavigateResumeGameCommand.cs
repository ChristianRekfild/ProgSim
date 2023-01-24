using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Infrastructure.Stores;
using Noob_Coder.Models;
using Noob_Coder.ViewModels;
using System.IO;
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

            _navigationStore.CurrentViewModel = new GameSceneViewModel(_navigationStore);


            if (_navigationStore.CurrentViewModel is GameSceneViewModel gameScene)
            {
                /// <summary>
                /// Установка параметров главного героя при запуске новой игры.
                /// Чтение из файла LastAutoSave.noob
                /// </summary>
                
                string jsonSaveString;
                using (StreamReader sr = new StreamReader("LastAutoSave.noob"))
                {
                    jsonSaveString = sr.ReadLine();
                }
                var saveProtagonist = JsonSerializer.Deserialize<Protagonist?>(jsonSaveString);
                gameScene.Protagonist.Health = saveProtagonist.Health; // значение здоровья главного героя игры по умолчанию
                gameScene.Protagonist.Money = saveProtagonist.Money; // значение наличных денег по умолчанию
                gameScene.Protagonist.Mustache = saveProtagonist.Mustache;  // значение усатости главного героя игры по умолчанию
                
            }
        }
    }
}
