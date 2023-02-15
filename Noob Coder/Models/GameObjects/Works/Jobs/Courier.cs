
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности курьера
    /// </summary>
    internal class Courier : Job
    {
         public Courier()
        {
            Name = Jobs.Courier.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
