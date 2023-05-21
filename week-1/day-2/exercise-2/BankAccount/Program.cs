namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create SavingsAccount and CheckingAccount objects and perform operations
            SavingsAccount savingsAccount = new SavingsAccount
            {
                AccountNumber = "Saving0001",
                InterestRate = 0.05m
            };

            CheckingAccount checkingAccount = new CheckingAccount
            {
                AccountNumber = "CUrrent001",
                OverdraftLimit = 500.00m
            };

            savingsAccount.Deposit(10000.00m);
            savingsAccount.Withdraw(2000.00m);

            checkingAccount.Deposit(5000.00m);
            checkingAccount.Withdraw(6000.00m);
            Console.ReadLine();
        }   
    }
}