﻿using Noob_Coder.Models;
using Noob_Coder.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Noob_Coder.UserInterface
{
    internal static class UI
    {
        /// <summary>
        /// Название текущего языка
        /// </summary>
        public static string Language {get; set;}

        #region Главное меню
        public static string MenuViewTitle {get; set;}
        public static string ResumeGameButtonName {get; set;}
        public static string NewGameButtonName {get; set;}
        public static string LoadGameButtonName {get; set;}
        public static string SettingsButtonName {get; set;}
        public static string FeedbackButtonName {get; set;}
        public static string ExitButtonName {get; set;}
        #endregion

        #region Подписи индикаторов
        public static string Health {get; set;}
        public static string Stamina {get; set;}
        public static string Appearance {get; set;}
        public static string Mood {get; set;}
        #endregion

        #region Должности
        public static string Loader {get; set;}
        public static string Seller {get; set;}
        public static string Worker {get; set;}
        public static string Courier {get; set;}
        public static string Animator {get; set;}
        public static string Cleaner {get; set;}
        public static string Intern {get; set;}
        public static string Junior {get; set;}
        public static string Middle {get; set;}
        public static string Senior {get; set;}
        public static string Lead {get; set;}
        #endregion


        /// <summary>
        /// получение значения свойства UI
        /// по переданной строке
        /// </summary>
        /// <param name="name"> строка и именем свойства</param>
        /// <returns>значение свойсва UI</returns>
        public static string GetPropValue(string name)
        {
            var result = Type.GetType("Noob_Coder.UserInterface.UI").GetProperty(name).GetValue(null);
            return result.ToString();
        }

        /// <summary>
        /// Выбор языка
        /// </summary>
        /// <param name="Language">язык на который нужно поменять</param>
        public static void ChangeUI(string language)
        {
            switch (language)
            {
                case "Русский":
                    RusUI.ChangeUI();
                    break;
                case "English":
                    EngUI.ChangeUI();
                    break;
            }
        }

    }
}
