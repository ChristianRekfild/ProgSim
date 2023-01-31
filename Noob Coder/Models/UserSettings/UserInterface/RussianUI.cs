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
            #region Главное меню
            MenuViewTitle = "Симулятор программиста: Меню";
            ResumeGameButtonName = "Продолжить игру";
            NewGameButtonName = "Новая игра";
            LoadGameButtonName = "Загрузить игру";
            SettingsButtonName = "Настройки";
            FeedbackButtonName = "Обратная связь";
            ExitButtonName = "Выход";
            #endregion

            Health = "Здоровье";

        }



        


    }
}
