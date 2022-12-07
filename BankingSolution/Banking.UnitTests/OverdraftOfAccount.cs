using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class OverdraftOfAccount
    {
        [Fact]
        public void CanTakeAllTheMoney()
        {
            var account = new BankAccount();
            account.Withdraw(account.GetBalance());

            Assert.Equal(0, account.GetBalance());
        }

        [Fact]
        public void OverDraftDoesNotDecreaseTheBalance()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = openingBalance + .01M;
        }
    }
}
