using System;

// Custom Exception
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Insufficient Balance! Withdrawal not allowed.");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}. Current Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(5000); // Initial balance

        Console.WriteLine("Current Balance: " + account.Balance);

        try
        {
            Console.WriteLine("\nTrying to withdraw 2000...");
            account.Withdraw(2000); // Valid

            Console.WriteLine("\nTrying to withdraw 4000...");
            account.Withdraw(4000); // Will throw custom exception
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("\nCustom Exception Caught: " + ex.Message);
        }

        Console.WriteLine("\nProgram Finished.");
    }
}
