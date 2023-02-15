
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности Junior
    /// </summary>
    internal class Junior : Job
    {
         public Junior()
        {
            Name = Jobs.Junior.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
