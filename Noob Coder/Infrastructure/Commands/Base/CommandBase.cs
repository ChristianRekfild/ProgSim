using System;
using System.Windows.Input;

namespace Noob_Coder.Infrastructure.Commands.Base
{
    /// <summary>
    /// Базовый класс команды. Если планируется создать команду и прописать в ней реализацию - наследоваться от неё.
    /// </summary>
    internal abstract class CommandBase : ICommand
    {
        /// <summary>
        /// Оповещает обработчики команд о том что изменился статус возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        /// <summary>
        /// Проверяет возможность выполнения команды в зависимости от заданных в методе условий.
        /// </summary>
        /// <returns>bool - можно ли выполнить команду. true - можно, false - нельзя.</returns>
        public abstract bool CanExecute(object? parameter);
        /// <summary>
        /// Выполняет команду, если CanExecute() вернёт true.
        /// </summary>
        public abstract void Execute(object? parameter);

    }
}
