namespace com.psybergate.assessment.dsnprg001.yournameandsurname
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var accountService = new AccountService();

            // Test Savings Account withdrawals
            accountService.Withdraw(1, 500);  // Should succeed
            accountService.Withdraw(1, 2000); // Should fail (minimum balance)

            // Test Current Account withdrawals
            accountService.Withdraw(3, 500);  // Should succeed
            accountService.Withdraw(4, 10000); // Should succeed
            accountService.Withdraw(4, 20000); // Should fail (exceeds overdraft)

            // Non-existent account
            accountService.Withdraw(999, 100); // Should notify account not found

            Console.Read();
        }   
    }
}