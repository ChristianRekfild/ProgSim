using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noob_Coder.Infrastructure.Commands.Base;
using Noob_Coder.Stores;
using Noob_Coder.ViewModels;

namespace Noob_Coder.Infrastructure.Commands
{
    internal class NavigateMenuCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigateMenuCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new MenuViewModel(_navigationStore);
        }
    }
}
