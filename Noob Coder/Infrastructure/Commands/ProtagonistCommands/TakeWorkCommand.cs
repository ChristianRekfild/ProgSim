using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Models;


namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда, позволяющая взять работу.
    /// </summary>
    internal class TakeWorkCommand : CommandBase
    {

        private Protagonist _protagonist;
        /// <summary>
        /// главный героя.
        /// </summary>
        public Protagonist Protagonist
        {
            get => _protagonist;
            set => _protagonist = value;
        }

        public TakeWorkCommand (Protagonist protagonist)
        {
            Protagonist = protagonist;
        }

        /// <summary>
        /// Проверяет доступность команды для выполнения.
        /// Если метод возвращает false - команду выполнить нельзя.
        /// </summary>
        /// <param name="parameter">object</param>
        /// <returns>bool</returns>
        public override bool CanExecute(object? parameter) => parameter is Work;
        /// <summary>
        /// Действие при выполнении команды
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            Protagonist.CurrentWork = (Work)parameter;
        }
    }
}
