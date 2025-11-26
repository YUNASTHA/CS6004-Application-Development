public class BankAccount
{
    private string accountNumber;
    private double balance;

    // Constructor
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;

        // Using the property to apply validation
        Balance = initialBalance;
    }

    // Public property for AccountNumber (GET only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property for Balance (set is private)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be zero or negative!");
            }
        }
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount!");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid withdraw amount or insufficient balance!");
        }
    }
}
