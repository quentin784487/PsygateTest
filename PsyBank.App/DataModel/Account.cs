namespace com.psybergate.assessment.dsnprg001.yournameandsurname
{
    public abstract class Account
    {
        public long Id { get; }
        public long AccountNum { get; }
        public int Balance { get; protected set; }
        public string CustomerNum { get; }

        protected Account(long id, long accountNum, int initialBalance, string customerNum)
        {
            Id = id;
            AccountNum = accountNum;
            Balance = initialBalance;
            CustomerNum = customerNum;
        }

        public abstract bool Withdraw(int amount);

        public override bool Equals(object obj)
        {
            if (obj is Account other)
                return AccountNum == other.AccountNum || Id == other.Id;
            return false;
        }

        public override int GetHashCode() => AccountNum.GetHashCode() ^ Id.GetHashCode();
    }
}
