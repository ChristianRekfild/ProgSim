using System;
using Noob_Coder.Infrastructure.Commands.Base;

namespace Noob_Coder.Infrastructure.Commands
{
    internal class RelayCommandBase : CommandBase
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommandBase(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;
        public override void Execute(object? parameter) => _execute(parameter);
    }
}
