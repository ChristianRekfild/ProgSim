
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности разнорабочего
    /// </summary>
    internal class Worker : Job
    {
         public Worker()
        {
            Name = Jobs.Worker.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
