using System.Collections.Generic;


namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель компании MediumITcompany
    /// </summary>
    internal class MediumITcompany : Company
    {

        public MediumITcompany()
        {
            Name = Companies.MediumITcompany.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 1, 15 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Intern, Jobs.Junior, Jobs.Middle, Jobs.Senior, Jobs.Lead}; //список возможных должностей из enum Jobs
            PayСoefficient = 0.8; //зарплатный коэффициент
        }
    }
}
