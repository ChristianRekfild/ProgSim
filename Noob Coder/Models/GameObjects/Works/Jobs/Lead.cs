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
    /// Модель должности Lead
    /// </summary>
    internal class Lead : Job
    {
         public Lead()
        {
            Name = Jobs.Senior; //название из enum, должно совпадать с именем класса
            Title = "TeamLead"; //отображаемое название из словаря
            MinSalaryPerDay = 1000; //минимальная зарплата
            MaxSalaryPerDay = 5000;//максимальная зарплата

        }

    }
}
