using System.Collections.Generic;


namespace Noob_Coder.Models
{       
    /// <summary>
    /// Модель компании BigItCompany
    /// </summary>
    internal class BigItCompany : Company
    {

        public BigItCompany()
        {
            Name = Companies.BigItCompany.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 1, 15 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Junior, Jobs.Middle, Jobs.Senior, Jobs.Lead}; //список возможных должностей из enum Jobs
            PayСoefficient = 0.9; //зарплатный коэффициент
        }
    }
}
