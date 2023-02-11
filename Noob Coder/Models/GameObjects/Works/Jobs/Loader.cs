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
    /// Модель должности грузчика
    /// </summary>
    internal class Loader : Job
    {
         public Loader()
        {
            Name = Jobs.Loader; //название из enum, должно совпадать с именем класса
            Title = "Гручик"; //отображаемое название из словаря
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
