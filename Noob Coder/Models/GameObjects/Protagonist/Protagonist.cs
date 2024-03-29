using System;
using System.Runtime.CompilerServices;

namespace Noob_Coder.Models
{
    /// <summary>
    /// Класс модели главного героя игры.
    /// </summary>
    internal class Protagonist : ModelBase
    {
        #region Свойства

        #region свойства на индикаторах
        private double _health;
        /// <summary>
        /// Здоровье главного героя игры.
        /// </summary>
        public double Health
        {
            get => _health;
            set => SetField(ref _health, value);

        }

        private double _stamina;
        /// <summary>
        /// Усталость главного героя игры.
        /// </summary>
        public double Stamina
        {
            get => _stamina;
            set => SetField(ref _stamina, value);
        }


        private double _appearance;
        /// <summary>
        /// Внешний вид (опрятность) главного героя игры.
        /// </summary>
        public double Appearance
        {
            get => _appearance;
            set => SetField(ref _appearance, value);
        }

        private double _mood;
        /// <summary>
        /// Настроение главного героя.
        /// </summary>
        public double Mood
        {
            get => _mood;
            set => SetField(ref _mood, value);

        }

        #endregion

        private Work _currentWork;
        /// <summary>
        /// Текущая работа.
        /// </summary>
        public Work CurrentWork
        {
            get => _currentWork;
            set => SetField(ref _currentWork, value);
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

        private DateTime _employmentDate;
        /// <summary>
        /// дата устройства на текущую работу
        /// </summary>
        public DateTime EmploymentDate
        {
            get => _employmentDate;
            set => SetField(ref _employmentDate, value);
        }


        private DateTime _lastSellaryDay;
        /// <summary>
        /// день последней выплаты
        /// </summary>
        public DateTime LastSellaryDay
        {
            get => _lastSellaryDay;
            set => SetField(ref _lastSellaryDay, value);
        }

        #endregion

        #region Методы
        /// <summary>
        /// Метод, вычисляющий, что случилось с главным героем игры за заданный промежуток времени.
        /// </summary>
        public void AnotherFuckingDay()
        {
           Health = _health - (110-Mood)/10; //ежедневное уменьшение здоровья в зависимости от настроения
        }

        /// <summary>
        /// Мертв ли главный герой.
        /// </summary>
        public bool IsDead() => Health <= 0;

        /// <summary>
        /// Метод изменяющий здоровье главного героя на передаваемую величину
        /// </summary>
        public void AddHealth(int value)
        {
            double result = Health + value;
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
        /// Метод изменяющий настроение на передаваемую величину
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

        //конструктор начального персонажа
        public Protagonist()
        {

        }

        public void GetSellary(DateTime lastSellaryDay, DateTime currentDay)
        {
            int sellary = CurrentWork.SalaryPerDay * Convert.ToInt32((currentDay - lastSellaryDay).TotalDays);
            Money += sellary;
            LastSellaryDay = currentDay;
        }

    }
}
