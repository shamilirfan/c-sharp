using System;

// 15
class BankAccount
{
    public string accountNumber { get; set; }
    public string customerName { get; set; }
    public double balance { get; private set; }

    public string Deposit(double amount)
    {
        balance += amount;
        return "Deposited";
    }

    public string Withdraw(double amount)
    {
        balance -= amount;
        return "Withdrawn";
    }
}

class SavingAccount : BankAccount
{
    public double interestAmount { get; set; }
}

class CheckingAccount : BankAccount
{
    public double serviceCharge { get; set; }
}

class UpcastingDowncasting
{
    public static void Main(string[] args)
    {
        SavingAccount sv1 = new SavingAccount();
        sv1.accountNumber = "sv-001";
        sv1.customerName = "Himal";
        sv1.interestAmount = 500;
        sv1.Deposit(1000);
        sv1.Withdraw(500);
        // Up casting
        BankAccount b1 = sv1;

        // Down casting
        SavingAccount sv2 = b1;
        SavingAccount sv3 = (SavingAccount)b1;

        Console.WriteLine($"{sv3.interestAmount}");
    }
}
