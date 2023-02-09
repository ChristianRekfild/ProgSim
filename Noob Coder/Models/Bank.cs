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
        private int _balance;
        /// <param>
        /// Баланс на банковском счету
        /// Отрицательный - кредит
        /// Положительный - депозит
        /// </param>
        public int Balance { get { return _balance; } }

        private int _maximumCredit;

        /// <summary>
        /// Взять в кредит (колво-денег).
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        public int GetDebt(int takedMoney) 
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
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        public int PayOffTheDebt(int payment)
        {
            if((payment > _balance)&&(_balance<=0))
            {
                int debt = -_balance;
                _balance = 0;
                return debt;
            }
            else
            {
                return 0;
            }
            
        }


        /// <summary>
        /// Обналичить депозит
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        public int CashOut(int takedMoney)
        {
            if(takedMoney > _balance)
            {
                _balance = 0; 
            }
            _balance += takedMoney;
            return 0;
        }

        /// <summary>
        /// Положить деньги в банк под проценты
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        public int DepositMoney(int takedMoney)
        {
            if (takedMoney > _balance)
            {
                _balance = 0;
            }
            _balance += takedMoney;
            return 0;
        }

        /// <summary>
        /// Пересчитать проценты ежедневные.
        /// </summary>
        /// <param name="takedMoney">Сколько денег хочет взять</param>
        public int RecalculateBankInterest(int takedMoney)
        {
            if (takedMoney > _balance)
            {
                _balance = 0;
            }
            _balance += takedMoney;
            return 0;
        }
    }
}
