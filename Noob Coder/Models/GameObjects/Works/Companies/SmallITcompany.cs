using System.Collections.Generic;


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
