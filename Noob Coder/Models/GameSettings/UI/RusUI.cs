using Noob_Coder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noob_Coder.UserInterface
{
    internal static class RusUI
    {
        public static void ChangeUI() 
        {
            UI.Language = "Русский";

            #region Главное меню
            UI.MenuViewTitle = "Noob_Coder.Главное меню";
            UI.ResumeGameButtonName = "Продолжить";
            UI.NewGameButtonName = "Новая Игра";
            UI.LoadGameButtonName = "Загрузить Игру";
            UI.SettingsButtonName = "Настройки";
            UI.FeedbackButtonName = "Обратная связь";
            UI.ExitButtonName = "Выход";
            #endregion

            #region Подписи индикаторов
            UI.Health = "Здоровье";
            UI.Stamina = "Усталость";
            UI.Appearance = "Опрятность";
            UI.Mood = "Настроение";
            #endregion

            #region Должности
            UI.Loader = "Грузчик";
            UI.Seller = "Продавец-кассир";
            UI.Worker = "Разнорабочий";
            UI.Courier = "Курьер";
            UI.Animator = "Аниматор в костюме Енота";
            UI.Cleaner = "Уборщик";
            UI.Intern = "Стажер";
            UI.Junior = "Junior";
            UI.Middle = "Moddle";
            UI.Senior = "Senior";
            UI.Lead = "TeamLead";
            #endregion
        }
    }
}
