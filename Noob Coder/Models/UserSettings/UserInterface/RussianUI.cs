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
    internal class RussianUI : UserInterface
    {

        public RussianUI ()
        {
            LanguageName = "Русский";

            #region MainMenu
            MenuViewTitle = "Симулятор программиста: Меню";
            ResumeGameButtonName = "Продолжить игру";
            NewGameButtonName = "Новая игра";
            LoadGameButtonName = "Загрузить игру";
            SettingsButtonName = "Настройки";
            FeedbackButtonName = "Обратная связь";
            ExitButtonName = "Выход";
            #endregion

            #region
            GSTabItemMain = "Главная";
            GSTabItemProperty = "Имущество";
            GSTabItemEducation = "Образование";
            GSTabItemFinance = "Финансы";

            Health = "Здоровье";
            Mustache = "Усатость";
            #endregion

            #region SettingMenu
            SettingMenuLanguage = "Выбор языка";
            SettingMenuBackButtonName = "Вернуться";
            #endregion

        }






    }
}
