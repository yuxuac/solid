namespace SOLID.LiskovSubstitutionPrinciple.ApplyLiskovSubstitution
{
    public class FixedTermDepositAccount : IAccount
    {
        decimal balance;
        public decimal Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposit ${amount}, balance now is ${balance}");
            return balance;
        }
    }
}