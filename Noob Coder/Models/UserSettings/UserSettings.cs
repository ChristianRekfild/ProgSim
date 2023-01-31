using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;

namespace Noob_Coder.Models 
{
    /// <summary>
    /// Класс модели .
    /// </summary>
    internal class UserSettings : ModelBase
    {
        #region Свойства
        private UserInterface _userInterface;
        /// <summary>
        /// Здоровье главного героя игры.
        /// </summary>
        public UserInterface UserInterface
        {
            get => _userInterface;
            set => SetField(ref _userInterface, value);

        }

        #endregion

        public UserSettings()
        {
            UserInterface = new RussianUI();
        }


    }
}
