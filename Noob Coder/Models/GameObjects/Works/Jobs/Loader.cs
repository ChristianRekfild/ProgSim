
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности грузчика
    /// </summary>
    internal class Loader : Job
    {
         public Loader()
        {
            Name = Jobs.Loader.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
