
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности Lead
    /// </summary>
    internal class Lead : Job
    {
         public Lead()
        {
            Name = Jobs.Senior.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 1000; //минимальная зарплата
            MaxSalaryPerDay = 5000;//максимальная зарплата

        }

    }
}
