
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности Senior
    /// </summary>
    internal class Senior : Job
    {
         public Senior()
        {
            Name = Jobs.Senior.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 500; //минимальная зарплата
            MaxSalaryPerDay = 1000;//максимальная зарплата

        }

    }
}
