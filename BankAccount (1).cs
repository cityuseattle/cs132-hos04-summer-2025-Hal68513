using System;

public class BankAccount
{
    private decimal balance;

    // private varable to store the balance
    public BankAccount(decimal intitialBalance)
    {
        balance = intitialBalance;
    }
    // create a function to deposit money into a bank account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive");
        }
    }
    // create a function to withdraw money and check the current balance
    public bool Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return false;
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount}. New Balance: {balance}");
            return true;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

}
