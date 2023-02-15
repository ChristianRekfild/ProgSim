using Noob_Coder.Infrastructure.Commands.Base;
using Microsoft.Extensions.DependencyInjection;
using Noob_Coder.Services;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда добавления здоровья главному герою.
    /// </summary>
    internal class SpeedUpCommand : CommandBase
    {

         public SpeedUpCommand()
        {
            
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
            App.Host.Services.GetRequiredService<GameBackgroundService>().ChangeSpeed(500);

        }
    }
}
