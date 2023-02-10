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
    /// Модель должности разнорабочего
    /// </summary>
    internal class Worker : Job
    {
         public Worker()
        {
            Name = Jobs.Worker; //название из enum, должно совпадать с именем класса
            Title = "Разнорабочий"; //отображаемое название из словаря
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
