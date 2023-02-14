using Noob_Coder.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            UI.ConverterCulture = new CultureInfo("ru-RU", false);

            #region Главное меню
            UI.MenuViewTitle = "Noob_Coder. Главное меню";
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
            UI.EmptyJob = "Безработный";
            UI.Loader = "Грузчик";
            UI.Seller = "Продавец-кассир";
            UI.Worker = "Разнорабочий";
            UI.Courier = "Курьер";
            UI.Animator = "Аниматор в костюме Енота";
            UI.Cleaner = "Уборщик";
            UI.Intern = "Стажер";
            UI.Junior = "Junior";
            UI.Middle = "Middle";
            UI.Senior = "Senior";
            UI.Lead = "TeamLead";
            #endregion

            #region Компании
            UI.EmptyCompany = "";
            UI.Minimarket = "Магазин Апельсин";
            UI.Supermarket = "Шестерочка";
            UI.Gipermarket = "ГиперПолоска";
            UI.Zoo = "Зоопарк Змеюка";
            UI.SmallITcompany = "ИП Горбунков С.С.";
            UI.MediumITcompany = "Большие решения";
            UI.BigItCompany = "Ключевая ставка";
            UI.MacroHard = "МакроХард";
            #endregion
        }
    }
}
