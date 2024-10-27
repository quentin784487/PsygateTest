namespace com.psybergate.assessment.dsnprg001.yournameandsurname
{
    public class InMemoryDB
    {
        private static readonly InMemoryDB _instance = new InMemoryDB();
        private readonly List<Account> _accounts;

        private InMemoryDB()
        {
            _accounts = new List<Account>
            {
                new SavingsAccount(101, 1, 2000, "C1"),
                new SavingsAccount(102, 2, 5000, "C2"),
                new CurrentAccount(103, 3, 1000, 10000, "C3"),
                new CurrentAccount(104, 4, -5000, 20000, "C4")
            };
        }

        public static InMemoryDB Instance => _instance;

        public Account GetAccount(long accountNum)
        {
            return _accounts.Find(acc => acc.AccountNum == accountNum);
        }
    }
}
