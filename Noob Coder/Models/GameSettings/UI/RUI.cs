using Noob_Coder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noob_Coder.UserInterface
{
    internal static class RUI
    {
        public static void ChangeUI() 
        {
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
        }
    }
}
