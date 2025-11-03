using System; 

class Account
{
    private double balance; 

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

class Program
{
    static void Main()
    {
        Account acc = new Account();
        acc.Deposit(500);
        acc.Withdraw(200);
        Console.WriteLine("Balance: " + acc.GetBalance());
    }
}
