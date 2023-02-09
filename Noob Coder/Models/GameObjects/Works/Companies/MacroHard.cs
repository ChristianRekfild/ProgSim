using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;
using System.Xml.Linq;

namespace Noob_Coder.Models
{
    internal class MacroHard : Company
    {
    
 

        

        public MacroHard()
        {
            Title = "MacroHard";
            PayСoefficient = 0.9;
            PayDay = new List<int>(12);
        }
    }
}
