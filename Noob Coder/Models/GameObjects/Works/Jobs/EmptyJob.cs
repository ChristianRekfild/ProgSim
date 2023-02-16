

namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель пустой должности
    /// </summary>
    internal class EmptyJob : Job
    {
         public EmptyJob()
        {
            Name = "EmptyJob"; //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
