using System;

// 16
class BankAccount
{
    public string? accountNumber { get; set; }
    public string? customerName { get; set; }
    public double balance { get; private set; }

    public string Deposit(double amount)
    {
        balance += amount;
        return "Deposited";
    }

    public virtual string Withdraw(double amount)
    {
        balance -= amount;
        return "Withdrawn";
    }
}

class SavingAccount : BankAccount
{
    public double interestAmount { get; set; }

    public override string Withdraw(double amount)
    {
        if (balance >= amount)
        {
            return base.Withdraw(amount);
        }
        else
        {
            return "Insufficient Balance!";
        }
    }
}

class CheckingAccount : BankAccount
{
    public double serviceCharge { get; set; }
}

class MethodOverriding
{
    public static void Main(string[] args)
    {
        SavingAccount sv1 = new SavingAccount();
        sv1.accountNumber = "101";
        sv1.customerName = "Rupa";
        sv1.interestAmount = 100;
        Console.WriteLine($"{sv1.Deposit(500)}");
        // Console.WriteLine($"{sv1.Withdraw(200)}");
        Console.WriteLine($"{sv1.Withdraw(2000)}");

        CheckingAccount ck1 = new CheckingAccount();
        ck1.accountNumber = "201";
        ck1.customerName = "Anika";
        ck1.serviceCharge = 100;
        Console.WriteLine(ck1.Deposit(500));
        Console.WriteLine(ck1.Withdraw(2000));
    }
}
