using Banking.Domain;

public class NewAccounts
{
    [Fact]
    public void HaveThecorrectOpeningBalance()
    {
        //Write the code You wish You Had 
        // Given
        var account = new BankAccount();
        // When
        decimal balance = account.GetBalance();
        //Then
        Assert.Equal(5000M, balance);
    }
}