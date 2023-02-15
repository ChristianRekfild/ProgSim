
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности Middle 
    /// </summary>
    internal class Middle : Job
    {
         public Middle()
        {
            Name = Jobs.Middle.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 200; //минимальная зарплата
            MaxSalaryPerDay = 300;//максимальная зарплата

        }

    }
}
