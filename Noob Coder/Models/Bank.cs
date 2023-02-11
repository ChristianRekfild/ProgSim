namespace Noob_Coder.Models
{
    /// <summary>
    /// Класс банк хранит значения счета клиента.
    /// Выдает кредит
    /// Гасит кредит
    /// Принимает деньги на депозит
    /// Выдает деньги с депозита
    /// </summary>
    internal class Bank
    {
        private static int _balance;
        /// <param>
        /// Баланс на банковском счету
        /// Отрицательный - кредит
        /// Положительный - депозит
        /// </param>
        public static int Balance { get { return _balance; } }

        private static int _maximumCredit;


        /// <summary>
        /// Взять в кредит (колво-денег).
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public static int GetDebt(int takedMoney) 
        {
            if (_balance - takedMoney < _maximumCredit)
            {
                int debt = _maximumCredit + takedMoney;
                _balance -= -debt;
                return takedMoney;
            }
            else if (_balance == _maximumCredit)
                return 0;
            else
            {
                _balance -= takedMoney;
                return takedMoney;
            }
            
        }

        /// <summary>
        /// Погасить кредит на сумму.
        /// </summary>
        /// <param name="payment">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public static int PayOffTheDebt(int payment)
        {
            if (_balance < 0)
            {
                if (payment > -_balance)
                {
                    _balance += payment;
                    return payment;
                }
                else
                {
                    int debt = -_balance;
                    _balance = 0;
                    return debt;
                }
            }
            else return 0;
            
        }

        /// <summary>
        /// Обналичить депозит
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public static int CashOut(int takedMoney)
        {
            if (_balance > 0)
            {
                if (takedMoney > _balance)
                {
                    _balance += takedMoney;
                    return takedMoney;
                }
                else
                {
                    int money = _balance;
                    _balance = 0;
                    return money;
                }
            }
            else return 0;

        }

        /// <summary>
        /// Положить деньги в банк под проценты
        /// </summary>
        /// <param name="payment">Сколько денег хочет взять</param>
        /// <returns>Изменение баланса</returns>
        public static int DepositMoney(int payment)
        {
            _balance += payment;
            return 0;
        }

        /// <summary>
        /// Пересчитать проценты ежедневные.
        /// </summary>
        public static void RecalculateBankInterest()
        {
            _balance =  _balance * 1001/1000;
        }
    }
}
