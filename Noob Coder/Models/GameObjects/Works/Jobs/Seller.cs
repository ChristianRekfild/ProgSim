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
    /// Модель должности продавца
    /// </summary>
    internal class Seller : Job
    {
         public Seller()
        {
            Name = Jobs.Seller; //название из enum, должно совпадать с именем класса
            Title = "Продавец-кассир"; //отображаемое название из словаря
            MinSalaryPerDay = 150; //минимальная зарплата
            MaxSalaryPerDay = 200;//максимальная зарплата

        }

    }
}
