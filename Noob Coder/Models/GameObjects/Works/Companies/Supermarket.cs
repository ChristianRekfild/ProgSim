using System.Collections.Generic;


namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель компании Supermarket
    /// </summary>
    internal class Supermarket : Company
    {

        public Supermarket()
        {
            Name = Companies.Supermarket.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 5, 20 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Loader, Jobs.Seller, Jobs.Worker, Jobs.Cleaner }; //список возможных должностей из enum Jobs
            PayСoefficient = 1; //зарплатный коэффициент
        }
    }
}
