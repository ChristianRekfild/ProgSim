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
            LanguageName = "English";

            #region MainMenu
            MenuViewTitle = "Stimulator of Pogromist: Tebu";
            ResumeGameButtonName = "Resume GAME";
            NewGameButtonName = "New Cool GAME";
            LoadGameButtonName = "Don't work";
            SettingsButtonName = "Settings, It's Work!!!";
            FeedbackButtonName = "Say HELLO!";
            ExitButtonName = "POKEDOVA";
            #endregion

            #region
            GSTabItemMain = "Main";
            GSTabItemProperty = "Property";
            GSTabItemEducation = "Education";
            GSTabItemFinance = "Finance";

            Health = "Zdorovie";
            #endregion

            #region SettingMenu
            SettingMenuLanguage = "Change :-P";
            SettingMenuBackButtonName = "Go Home";
            #endregion
        }

#endregion




    }
}
