class Program
{
    static void Main(string[] args)
    {
        // Creating bank account object
        BankAccount acc = new BankAccount("ACC12345", 2000);

        // Displaying account number
        Console.WriteLine("Account Number: " + acc.AccountNumber);

        // Depositing the money
        acc.Deposit(1500);

        // Withdrawing the money
        acc.Withdraw(2000);

        // Displaying the remaining balance
        Console.WriteLine("Remaining Balance: " + acc.Balance);
    }
}
