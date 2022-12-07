using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        public void GetBonusOnDeposit()
        {
            // Give (Context)
            var account = new BankAccount();
            account.AccountType = BankAccountType.Gold;
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;
            var expectedBonus = 10M;

            //When
            account.Deposit(amountToDeposit);

            //Then
            Assert.Equal(openingBalance + amountToDeposit + expectedBonus, 
                account.GetBalance());
            //inheritance
        }
    }
}
