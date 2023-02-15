using System.Collections.Generic;


namespace Noob_Coder.Models
{        
    /// <summary>
    /// Пустая компания
     /// </summary>
    internal class EmptyCompany : Company
    {

        public EmptyCompany()
        {

            Name = "EmptyCompany"; //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 1 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> {Jobs.Loader}; //список возможных должностей из enum Jobs
            PayСoefficient = 0; //зарплатный коэффициент
        }
    }
}
