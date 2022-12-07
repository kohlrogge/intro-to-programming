using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    internal class WorkingWithMultipleAccounts
    {
        [Fact]

        public void InstanceOfOurAccountsAreIsolated()
        {
            var bobsAccount = new BankAccount();
            var suesAccount = new BankAccount();

            bobsAccount.Deposit(100M);
            suesAccount.Withdraw(suesAccount.GetBalance());

            Assert.Equal(6000, bobsAccount.GetBalance());
            Assert.Equal(0, suesAccount.GetBalance());
        }
    }
}
