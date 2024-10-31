namespace PsyBank.App.Service.Contracts
{
    public interface IAccountService
    {
        void Withdraw(long accountNum, int amountToWithdraw);
    }
}
