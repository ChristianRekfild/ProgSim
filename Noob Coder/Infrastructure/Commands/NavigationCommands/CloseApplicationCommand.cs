using System.Windows;
using Noob_Coder.Infrastructure.Commands.Base;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда закрытия приложения.
    /// </summary>
    internal class CloseApplicationCommand : CommandBase
    {
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
        public override void Execute(object? parameter) => Application.Current.Shutdown();
    }
}
