
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности уборщика
    /// </summary>
    internal class Cleaner : Job
    {
         public Cleaner()
        {
            Name = Jobs.Cleaner.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
