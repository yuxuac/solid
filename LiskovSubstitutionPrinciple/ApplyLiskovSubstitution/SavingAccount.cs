namespace SOLID.LiskovSubstitutionPrinciple.ApplyLiskovSubstitution
{
    public class SavingAccount: IWithdrawableAccount
    {
        decimal balance;
        public decimal Withdraw(decimal amount)
        {
            if(balance <= amount)
                throw new Exception($"Failed to withdraw: balance ${balance} is less than withdraw amount ${amount}.");
            balance -= amount;
            Console.WriteLine($"Withdraw ${amount}, balance now is ${balance}");
            return balance;
        }

        public decimal Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposit ${amount}, balance now is ${balance}");
            return balance;
        }
    }
}