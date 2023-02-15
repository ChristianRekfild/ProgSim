
namespace Noob_Coder.Models
{
    /// <summary>
    /// Модель должности аниматора
    /// </summary>
    internal class Animator : Job
    {
         public Animator()
        {
            Name = Jobs.Animator.ToString(); //название из enum, должно совпадать с именем класса
            MinSalaryPerDay = 80; //минимальная зарплата
            MaxSalaryPerDay = 120;//максимальная зарплата

        }

    }
}
