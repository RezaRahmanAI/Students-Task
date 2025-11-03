abstract class Bank
{
    public abstract void withdraw(double amount);
    public abstract void deposit(double amount);
}

class Account : Bank
{
    double balance;

    public override void withdraw(double amount)
    {
        if (balance < amount)
            Console.WriteLine("Insufficient Balance");
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}\nRemaining balance: {balance}");
        }
    }

    public override void deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}\nNew balance: {balance}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account();
        acc.deposit(1000);
        acc.withdraw(200);
    }
}
