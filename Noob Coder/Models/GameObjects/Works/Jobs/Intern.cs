
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности стажера
    /// </summary>
    internal class Intern : Job
    {
        public Intern()
        {
            Name = Jobs.Intern.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 0; //минимальная зарплата
            MaxSalaryPerDay = 20;//максимальная зарплата

        }

    }
}
