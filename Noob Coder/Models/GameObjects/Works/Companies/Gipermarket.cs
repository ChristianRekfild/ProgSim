using System.Collections.Generic;


namespace Noob_Coder.Models
{        
    /// <summary>
    /// Модель компании Gipermarket
     /// </summary>
    internal class Gipermarket : Company
    {

        public Gipermarket()
        {
            Name = Companies.Gipermarket.ToString(); //название из enum, должно совпадать с именем класса
            PayDay = new List<int> { 1, 15 }; //список дней зарплаты
            PossibleJobs = new List<Jobs> { Jobs.Loader, Jobs.Seller, Jobs.Worker, Jobs.Cleaner }; //список возможных должностей из enum Jobs
            PayСoefficient = 1.2; //зарплатный коэффициент
        }
    }
}
