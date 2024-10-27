namespace com.psybergate.assessment.dsnprg001.yournameandsurname
{
    public class SavingsAccount : Account
    {
        private const int MinimumBalance = 1000;

        public SavingsAccount(long id, long accountNum, int initialBalance, string customerNum) : base(id, accountNum, initialBalance, customerNum)
        {
            if (initialBalance < MinimumBalance)
                throw new ArgumentException("Initial balance must be at least R1000");
        }

        public override bool Withdraw(int amount)
        {
            if (amount <= 0 || Balance - amount < MinimumBalance)
                return false;

            Balance -= amount;
            return true;
        }
    }
}
