using System.Collections.Generic;


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
