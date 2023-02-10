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
    internal class BigItCompany : Company
    {
        /// <summary>
        /// Модель компании BigItCompany
        /// </summary>
        public BigItCompany()
        {
            Name = Companies.BigItCompany; //название из enum, должно совпадать с именем класса
            Title = "Сложые решения"; //отображаемое название из словаря
            PayDay = new List<int> { 1, 15 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Junior, Jobs.Middle, Jobs.Senior, Jobs.Lead}; //список возможных должностей из enum Jobs
            PayСoefficient = 0.9; //зарплатный коэффициент
        }
    }
}
