using System.IO;
using Noob_Coder.UserInterface;
using System.Text.Json;


namespace Noob_Coder.Models
{
    internal class SettingsSaveModel
    {
        public  string UILanguage { get; set; }


       public SettingsSaveModel()
        {
            UILanguage = UI.Language;
        }

        public void Load()
        {
            if (File.Exists(Path.Combine(App.CurrentAppRunningDirectory(), "settings.noob")))
            {
                string jsonSaveString;
                using (StreamReader sr = new StreamReader("settings.noob"))
                {
                    jsonSaveString = sr.ReadLine();
                }
                SettingsSaveModel settingsSaveModel = JsonSerializer.Deserialize<SettingsSaveModel?>(jsonSaveString);
                UI.ChangeUI(settingsSaveModel.UILanguage);
            }
            else
            {
                UI.ChangeUI("Русский");
            }

        }

        public void Save()
        {
            string jsonSaveString = JsonSerializer.Serialize(this);
            using (StreamWriter sw = new StreamWriter("settings.noob"))
            {
                sw.WriteLine(jsonSaveString);
            }
        }


    }
}
