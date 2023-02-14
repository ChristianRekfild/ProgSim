using Noob_Coder.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Noob_Coder.UserInterface
{
    internal static class UI
    {
        #region Должности
        public static string Loader { get; set; }
        public static string Seller { get; set; }
        public static string Worker { get; set; }
        public static string Courier { get; set; }
        public static string Animator { get; set; }
        public static string Cleaner { get; set; }
        public static string Intern { get; set; }
        public static string Junior { get; set; }
        public static string Middle { get; set; }
        public static string Senior { get; set; }
        public static string Lead { get; set; }
        #endregion


        
        public static string GetPropValue(string name)
        {
          
            var result = Type.GetType("Noob_Coder.UserInterface.UI").GetProperty(name).GetValue(null);

            return result.ToString();
        }


    }
}
