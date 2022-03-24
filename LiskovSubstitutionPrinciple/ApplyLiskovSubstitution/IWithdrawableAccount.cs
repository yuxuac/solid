namespace SOLID.LiskovSubstitutionPrinciple.ApplyLiskovSubstitution
{
    public interface IWithdrawableAccount: IAccount
    {
         decimal Withdraw(decimal amount);
    }
}