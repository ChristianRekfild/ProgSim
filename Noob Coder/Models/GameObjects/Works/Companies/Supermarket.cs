using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;
using System.Xml.Linq;
using System.Reflection;
using System.Windows.Controls;
using System.Windows;

namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель компании Supermarket
    /// </summary>
    internal class Supermarket : Company
    {

        public Supermarket()
        {
            Name = Companies.Supermarket.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 5, 20 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Loader, Jobs.Seller, Jobs.Worker, Jobs.Cleaner }; //список возможных должностей из enum Jobs
            PayСoefficient = 1; //зарплатный коэффициент
        }
    }
}
