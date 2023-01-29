﻿using System.Windows;
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
    internal class RobCaravanCommand : CommandBase
    {
        Protagonist Protagonist { get; set; }   
        public RobCaravanCommand(Protagonist protagonist)
        {
            Protagonist = protagonist;
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
             Protagonist.RobCaravan();
        }
    }
}
