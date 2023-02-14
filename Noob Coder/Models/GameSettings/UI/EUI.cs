using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noob_Coder.UserInterface
{
    internal static class EUI
    {
        public static void ChangeUI() 
        {
            UI.Loader = "Loader";
            UI.Seller = "Seller";
            UI.Worker = "Worker";
            UI.Courier = "Courier";
            UI.Animator = "Animator";
            UI.Cleaner = "Cleaner";
            UI.Intern = "Intern";
            UI.Junior = "Junior";
            UI.Middle = "Middle";
            UI.Senior = "Senior";
            UI.Lead = "Lead";
        }
    }
}
