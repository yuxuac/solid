namespace SOLID.LiskovSubstitutionPrinciple.ApplyOpenClose
{
    public interface IAccount
    {
         decimal Withdraw(decimal amount);
         decimal Deposit(decimal amount);
    }
}