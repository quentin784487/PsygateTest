namespace com.psybergate.assessment.dsnprg001.yournameandsurname
{
    public class CurrentAccount : Account
    {
        public int Overdraft { get; }

        public CurrentAccount(long id, long accountNum, int initialBalance, int overdraft, string customerNum) : base(id, accountNum, initialBalance, customerNum)
        {
            Overdraft = overdraft;
        }

        public override bool Withdraw(int amount)
        {
            if (amount <= 0 || amount > Balance + Overdraft)
                return false;

            Balance -= amount;
            return true;
        }
    }
}
