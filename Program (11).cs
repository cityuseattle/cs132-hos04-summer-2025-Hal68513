class Program
{
    // create a function to test all methods in bank account file
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount(1000);

        myAccount.Deposit(500);
        if (myAccount.Withdraw(200))
        {
            Console.WriteLine($"Withdrawal successful. Current Balance: {myAccount.GetBalance()}");

        }
        else
        {
            Console.WriteLine("Withdrawal failed");
        }
    }
}
