using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;
using System.Xml.Linq;

namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности аниматора
    /// </summary>
    internal class Animator : Job
    {
         public Animator()
        {
            Name = Jobs.Animator; //название из enum, должно совпадать с именем класса
            Title = "Аниматор в костюме енота"; //отображаемое название из словаря
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
