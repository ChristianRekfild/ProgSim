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

        private int _mood;
        /// <summary>
        /// Настроение.
        /// </summary>
        public int Mood
        {
            get => _mood;
            set => SetField(ref _mood, value);

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

        /// <summary>
        /// Метод, позволяющий грабить корованы
        /// </summary>
        public void RobCaravan()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 10);

            if (value < 5) Health = Health / 2;
            else Money = Money + value * 1000;
        }

        /// <summary>
        /// Метод, позволяющий грабить корованы
        /// </summary>
        public void MoodChange(int value)
        {
            Mood = Mood + value;
        }

        /// <summary>
        /// Баланс в банке
        /// </summary>
        /// <returns>Баланс в банке</returns>
        public int GetBankBalance() => Bank.Balance;
        /// <summary>
        /// Взять в кредит (колво-денег).
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public int GetDebt(int takedMoney) => Bank.GetDebt(takedMoney);
        /// <summary>
        /// Погасить кредит на сумму.
        /// </summary>
        /// <param name="payment">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public int PayOffTheDebt(int payment) => Bank.PayOffTheDebt(payment);
        /// <summary>
        /// Обналичить депозит
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public int CashOut(int takedMoney) => Bank.CashOut(takedMoney);
        /// <summary>
        /// Положить деньги в банк под проценты
        /// </summary>
        /// <param name="payment">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public int DepositMoney(int payment) => Bank.DepositMoney(payment);

        #endregion


    }
}
