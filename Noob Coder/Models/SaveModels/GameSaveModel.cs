using System;
using System.IO;
using System.Text;
using System.Text.Json;

using Noob_Coder.Models;


namespace Noob_Coder.Models
{
    internal class GameSaveModel
    {
        public Protagonist Protagonist { get; set; } //протогонист

        public GameSettings GameSettings { get; set; } //игровые параметры


        public GameSaveModel(Protagonist protagonist, GameSettings gameSettings)
        {
            Protagonist = protagonist;
            GameSettings = gameSettings;
        }
        public GameSaveModel() 
        {

        }

        public GameSaveModel Load(string fileName)
        {
                string jsonSaveString;
                var filePath = Path.Combine(App.CurrentAppRunningDirectory(), "Saves", fileName);
                using (StreamReader sr = new StreamReader(filePath))
                {
                    jsonSaveString = sr.ReadLine();
                }
                jsonSaveString = Encoding.UTF8.GetString(Convert.FromBase64String(jsonSaveString));//декодирование сейв файла
                GameSaveModel gameSaveModel = JsonSerializer.Deserialize<GameSaveModel?>(jsonSaveString);
                return gameSaveModel;

        }

        public void Save(string fileName)
        {
            var savesDirectoryPath = Path.Combine(App.CurrentAppRunningDirectory(), "Saves");
            if (!Directory.Exists(savesDirectoryPath))
            {
                DirectoryInfo dir = new DirectoryInfo(savesDirectoryPath);
                dir.Create();
            }
            string jsonSaveString = JsonSerializer.Serialize(this);
            var filePath = Path.Combine(savesDirectoryPath, fileName);
            jsonSaveString = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonSaveString)); //кодирование сейв файла
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(jsonSaveString);
            }
        }


    }
}


