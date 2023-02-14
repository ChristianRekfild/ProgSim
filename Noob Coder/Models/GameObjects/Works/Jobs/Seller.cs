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
            Name = Jobs.Seller.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 150; //минимальная зарплата
            MaxSalaryPerDay = 200;//максимальная зарплата

        }

    }
}
