using PsyBank.App.Service.Contracts;

namespace com.psybergate.assessment.dsnprg001.yournameandsurname
{
    public class AccountService : IAccountService
    {
        public void Withdraw(long accountNum, int amountToWithdraw)
        {
            var account = InMemoryDB.Instance.GetAccount(accountNum);
            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            if (account.Withdraw(amountToWithdraw))
            {
                Console.WriteLine($"Withdrawal of R{amountToWithdraw} successful. New balance: R{account.Balance}");
            }
            else
            {
                Console.WriteLine($"Withdrawal of R{amountToWithdraw} failed. Insufficient funds or minimum balance not maintained.");
            }
        }
    }
}
