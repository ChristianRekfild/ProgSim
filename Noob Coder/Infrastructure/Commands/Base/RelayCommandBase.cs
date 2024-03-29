﻿using System;
using Noob_Coder.Infrastructure.Commands.Base;

namespace Noob_Coder.Infrastructure.Commands
{
    /// <summary>
    /// Команда, которая может потребовать специфическую логику. Позволяет задать логику методов Execute() и CanExecute() при создании. 
    /// </summary>
    internal class RelayCommandBase : CommandBase
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;
        /// <summary>
        /// Принимает два делегата Action для логики метода Execute(), Func&lt;object, bool&gt; для метода CanExecute (необязательный)
        /// </summary>
        /// <param name="execute">Метод описывает логику выполнения команды</param>
        /// <param name="canExecute">Метод описывает логику возможности выполнения команды.
        /// Необязательный параметр - если не передать CanExecute() будет всегда возвращать true</param>
        /// <exception cref="ArgumentNullException">Вызывает исключение, если передать null, вместо метода, описывающего логику выполнения команды</exception>
        public RelayCommandBase(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;
        public override void Execute(object? parameter) => _execute(parameter);
    }
}
