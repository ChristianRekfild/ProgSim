using System.Windows;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.ViewModels;
using Noob_Coder.Models;


namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда добавления здоровья главному герою.
    /// </summary>
    internal class AddProtagonistHealthCommand : CommandBase
    {
        Protagonist _protagonist;
        int _addHealthValue;
        public AddProtagonistHealthCommand(Protagonist protagonist, int value)
        {
            _protagonist = protagonist;
            _addHealthValue = value;
        }
        /// <summary>
        /// Проверяет доступность команды для выполнения.
        /// Если метод возвращает false - команду выполнить нельзя.
        /// </summary>
        /// <param name="parameter">object</param>
        /// <returns>bool</returns>
        public override bool CanExecute(object? parameter) => true;
        /// <summary>
        /// Действие при выполнении команды
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            _protagonist.AddHealth(_addHealthValue);
        }
    }
}
