// See https://aka.ms/new-console-template for more information
using System;

class Account
{
    private double balance;
    public string hello = "Hello world";

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class GFG
{
    static void Main()
    {
        Account acc = new Account();
        acc.Deposit(500);
        acc.Withdraw(200);
        Console.WriteLine("Balance: " + acc.GetBalance());

        Console.WriteLine(acc.hello);

        acc.hello = "new world";
        Console.WriteLine(acc.hello);
        
    }
}