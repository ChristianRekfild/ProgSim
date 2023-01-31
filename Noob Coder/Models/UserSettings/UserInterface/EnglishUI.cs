using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;

namespace Noob_Coder.Models 
{
    /// <summary>
    /// Класс модели .
    /// </summary>
    internal class EnglishUI : UserInterface
    {
        #region Свойства
        public EnglishUI()
        {
            #region Главное меню
            MenuViewTitle = "Stimulator of Pogromist: Tebu";
            ResumeGameButtonName = "Resume GAME";
            NewGameButtonName = "New Cool GAME";
            LoadGameButtonName = "Don't work";
            SettingsButtonName = "Settings, Don'tWork";
            FeedbackButtonName = "Say HELLO!";
            ExitButtonName = "POKEDOVA";
            #endregion
            Health = "Zdorovie";

        }

        #endregion

        


    }
}
