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
    /// Модель должности Junior
    /// </summary>
    internal class Junior : Job
    {
         public Junior()
        {
            Name = Jobs.Junior.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
