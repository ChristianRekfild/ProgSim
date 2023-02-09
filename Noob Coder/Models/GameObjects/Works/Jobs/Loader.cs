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
    internal class Loader : Job
    {
 
        public Loader()
        {
            Title = "Грузчик";
            MinSalaryPerDay = 150;
            MaxSalaryPerDay = 250;

        }

    }
}
