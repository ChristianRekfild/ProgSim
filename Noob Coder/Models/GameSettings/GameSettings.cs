using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Noob_Coder.Models.Base;

/// <summary>
/// Класс модели основных игровых свойств.
/// </summary>
namespace Noob_Coder.Models 
{
    /// <summary>
    /// Класс модели .
    /// </summary>
    internal class GameSettings : ModelBase
    {
        #region Свойства
        private DateTime _currentDate;
        /// <summary>
        /// Текущая игровая дата
        /// </summary>
        public DateTime CurrentDate
        {
            get => _currentDate;
            set => SetField(ref _currentDate, value);
        }

        #endregion

        #region Методы
        
        #endregion

        public GameSettings()
        {
            CurrentDate = new DateTime(2023, 2, 1);
        }


    }
}
