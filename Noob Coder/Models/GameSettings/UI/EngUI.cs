using Noob_Coder.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noob_Coder.UserInterface
{
    internal static class EngUI
    {
        public static void ChangeUI() 
        {
            UI.Language = "English";
            UI.ConverterCulture = new CultureInfo("en-US", false);

            #region Главное меню
            UI.MenuViewTitle = "Noob_Coder.MainMenu";
            UI.ResumeGameButtonName = "Resume Game";
            UI.NewGameButtonName = "New Game";
            UI.LoadGameButtonName = "Load Game";
            UI.SettingsButtonName = "Settings";
            UI.FeedbackButtonName = "Feedback";
            UI.ExitButtonName = "Exit";
            #endregion

            #region Подписи индикаторов
            UI.Health = "Health";
            UI.Stamina = "Stamina";
            UI.Appearance = "Appearance";
            UI.Mood = "Mood";
            #endregion

            #region Должности
            UI.EmptyJob = "Jobless";
            UI.Loader = "Loader";
            UI.Seller = "Seller";
            UI.Worker = "Worker";
            UI.Courier = "Courier";
            UI.Animator = "Animator";
            UI.Cleaner = "Cleaner";
            UI.Intern = "Intern";
            UI.Junior = "Junior";
            UI.Middle = "Middle";
            UI.Senior = "Senior";
            UI.Lead = "Lead";
            #endregion

            #region Компании
            UI.EmptyCompany = "";
            UI.Minimarket = "Minimarket";
            UI.Supermarket = "Supermarket";
            UI.Gipermarket = "Gipermarket";
            UI.Zoo = "Zoo";
            UI.SmallITcompany = "SmallITcompany";
            UI.MediumITcompany = "MediumITcompany";
            UI.BigItCompany = "BigItCompany";
            UI.MacroHard = "MacroHard";
            #endregion
        }
    }
}
