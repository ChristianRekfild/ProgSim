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
    /// Модель компании SmallITcompany
    /// </summary>
    internal class SmallITcompany : Company
    {

        public SmallITcompany()
        {
            Name = Companies.SmallITcompany.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 1, 15 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Courier, Jobs.Intern, Jobs.Junior, Jobs.Middle, Jobs.Senior}; //список возможных должностей из enum Jobs
            PayСoefficient = 0.7; //зарплатный коэффициент
        }
    }
}
