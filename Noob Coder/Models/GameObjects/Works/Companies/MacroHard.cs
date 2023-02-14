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
    /// Модель компании MacroHard
    /// </summary>
    internal class MacroHard : Company
    {

        public MacroHard()
        {
            Name = Companies.MacroHard.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 1, 15 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Middle, Jobs.Senior, Jobs.Lead}; //список возможных должностей из enum Jobs
            PayСoefficient = 4.9; //зарплатный коэффициент
        }
    }
}
