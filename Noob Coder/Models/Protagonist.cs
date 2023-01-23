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
    /// Класс модели главного героя игры.
    /// </summary>
    internal class Protagonist : ModelBase
    {
        #region Свойства
        private int _health;
        /// <summary>
        /// Здоровье главного героя игры.
        /// </summary>
        public int Health
        {
            get => _health;
            set => SetField(ref _health, value);

        }

        private int _money;
        /// <summary>
        /// Наличные деньги.
        /// </summary>
        public int Money
        {
            get => _money;
            set => SetField(ref _money, value);

        }

       
        private double _mustache;
        /// <summary>
        /// Усатость главного героя игры.
        /// </summary>
        public double Mustache
        {
            get => _mustache;
            set => SetField(ref _mustache, value);
        }

        #endregion

        #region Методы
        /// <summary>
        /// Метод, вычисляющий, что случилось с главным героем игры за заданный промежуток времени.
        /// </summary>
        public void AnowerFuckingDay()
        {
            Health = _health - 1; 
            Mustache = _mustache + 0.5f;
        }

        /// <summary>
        /// Метод, проверяющий жив ли главный герой.
        /// </summary>
        public bool IsNotDie()
        {
            bool result = true;
            if (Health < 0) result = false;
            if (Mustache > 100) result = false;
            return result;
        }

        /// <summary>
        /// Метод добавляющий здоровья главному герою
        /// </summary>
        public void AddHealth(int value)
        {
            int result = Health + value;
            if (result > 100) Health = 100;
            else Health = result;
        }

        #endregion


    }
}
