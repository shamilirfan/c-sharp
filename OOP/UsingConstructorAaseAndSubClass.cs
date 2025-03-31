using System;

// 17
class BankAccount
{
    public string? accountNumber { get; set; }
    public string? customarName { get; set; }

    public BankAccount(string accountNumber, string customarName)
    {
        this.accountNumber = accountNumber;
        this.customarName = customarName;
    }
}

class SavingAccount : BankAccount
{
    public double interestAmount { get; set; }

    public SavingAccount(string accountNumber, string customarName, double interestAmount)
        : base(accountNumber, customarName)
    {
        this.interestAmount = interestAmount;
    }
}

class CheckingAccount : BankAccount
{
    public double serviceCharge { get; set; }

    public CheckingAccount(string accountNumber, string customarName, double serviceCharge)
        : base(accountNumber, customarName)
    {
        this.serviceCharge = serviceCharge;
    }
}

class UsingConstructorAaseAndSubClass
{
    public static void Main(string[] args)
    {
        SavingAccount sv1 = new SavingAccount("101", "Anis", 100);
        CheckingAccount ck1 = new CheckingAccount("201", "Bob", 200);

        Console.WriteLine($"{sv1.accountNumber}, {sv1.customarName}, {sv1.interestAmount}");
        Console.WriteLine($"{ck1.accountNumber}, {ck1.customarName}, {ck1.serviceCharge}");
    }
}
