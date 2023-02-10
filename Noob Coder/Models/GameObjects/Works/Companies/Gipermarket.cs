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
    internal class Gipermarket : Company
    {
        /// <summary>
        /// Модель компании Gipermarket
        /// </summary>
        public Gipermarket()
        {
            Name = Companies.Gipermarket; //название из enum, должно совпадать с именем класса
            Title = "ГиперПолоска"; //отображаемое название из словаря
            PayDay = new List<int> { 1, 15 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Loader, Jobs.Seller, Jobs.Worker, Jobs.Cleaner }; //список возможных должностей из enum Jobs
            PayСoefficient = 1.2; //зарплатный коэффициент
        }
    }
}
