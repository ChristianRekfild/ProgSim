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
    /// Модель должности Middle 
    /// </summary>
    internal class Middle : Job
    {
         public Middle()
        {
            Name = Jobs.Middle; //название из enum, должно совпадать с именем класса
            Title = "Middle разработчик"; //отображаемое название из словаря
            MinSalaryPerDay = 200; //минимальная зарплата
            MaxSalaryPerDay = 300;//максимальная зарплата

        }

    }
}
