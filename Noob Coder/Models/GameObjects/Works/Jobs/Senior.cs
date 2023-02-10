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
    /// Модель должности Senior
    /// </summary>
    internal class Senior : Job
    {
         public Senior()
        {
            Name = Jobs.Senior; //название из enum, должно совпадать с именем класса
            Title = "Senior разработчик"; //отображаемое название из словаря
            MinSalaryPerDay = 500; //минимальная зарплата
            MaxSalaryPerDay = 1000;//максимальная зарплата

        }

    }
}
