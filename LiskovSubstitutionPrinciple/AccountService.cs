using SOLID.LiskovSubstitutionPrinciple.ApplyLiskovSubstitution;

namespace SOLID.LiskovSubstitutionPrinciple
{
    public class AccountService
    {
        IWithdrawableAccount account;
        public AccountService(IWithdrawableAccount account)
        {
            this.account = account;
        }

        public decimal Withdraw(decimal amount)
        {
            return this.account.Withdraw(amount);
        }

        public decimal Deposit(decimal amount)
        {
            return this.account.Deposit(amount);
        }
    }
}