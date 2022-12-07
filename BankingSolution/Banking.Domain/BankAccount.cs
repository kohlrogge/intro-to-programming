namespace Banking.Domain
{
    public enum BankAccountType { Standard, Gold };
    public class BankAccount
    {
        private decimal _balance;
       
        

        public decimal GetBalance()
        {
            return _balance;
        }
        public void Withdraw(decimal amountToWithdraw)
        {
            _balance = _balance - amountToWithdraw;
        }

        public void Deposit(decimal amountToDeposit) 
        {
            _balance += amountToDeposit;
        }

    }
}