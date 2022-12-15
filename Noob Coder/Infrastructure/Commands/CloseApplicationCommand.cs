using System.Windows;
using Noob_Coder.Infrastructure.Commands.Base;

namespace Noob_Coder.Infrastructure.Commands
{
    internal class CloseApplicationCommand : CommandBase
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter) => Application.Current.Shutdown();
    }
}
