namespace Noob_Coder.Models
{
    internal class Bank
    {
        private int _balance;
        private int _maximumCredit;

        public int GetDebt(int debt)
        {
            if (_balance - debt < _maximumCredit)
            {
                _balance -= debt;
            }
            else
            {
                _balance = _maximumCredit;
            }
        }

        public int PayOffTheDebt(int payment)
        {
            _balance += payment;
        }
    }
}
