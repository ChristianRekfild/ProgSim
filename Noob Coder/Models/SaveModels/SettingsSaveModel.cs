using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Noob_Coder.UserInterface;
using System.Text.Json;
using Noob_Coder.Models;

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
            using (StreamWriter sw = new StreamWriter("settings.noob2"))
            {
                sw.WriteLine(jsonSaveString);
            }
        }


    }
}
