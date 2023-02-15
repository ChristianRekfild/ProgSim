using System.Collections.Generic;


namespace Noob_Coder.Models
{   
    /// <summary>
    /// Модель компании Zoo
    /// </summary>
    internal class Zoo : Company
    {

        public Zoo()
        {
            Name = Companies.Zoo.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 1 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Animator, Jobs.Cleaner, Jobs.Worker}; //список возможных должностей из enum Jobs
            PayСoefficient = 0.9; //зарплатный коэффициент
        }
    }
}
