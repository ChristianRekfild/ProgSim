using System.Windows;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.ViewModels;
using Noob_Coder.Models;
using Noob_Coder.Infrastructure.Stores;
using System;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда добавления здоровья главному герою.
    /// </summary>
    internal class ChangeMoodCommand : CommandBase
    {

        private int _mood;
        /// <summary>
        /// Количество добавляемого здоровья.
        /// </summary>
        public int Mood
        {
            get => _mood;
            set => _mood = value;
        }

        public ChangeMoodCommand(int value)
        {
            Mood = value;
        }

        /// <summary>
        /// Проверяет доступность команды для выполнения.
        /// Если метод возвращает false - команду выполнить нельзя.
        /// </summary>
        /// <param name="parameter">object</param>
        /// <returns>bool</returns>
        public override bool CanExecute(object? parameter) => parameter is Protagonist;
        /// <summary>
        /// Действие при выполнении команды
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            var protogonist = (Protagonist) parameter;
            protogonist.MoodChange(Mood);

        }
    }
}
