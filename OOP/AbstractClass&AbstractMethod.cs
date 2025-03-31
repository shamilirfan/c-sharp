using System;

// 19
public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public string CustomerName { get; set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, string customerName)
    {
        AccountNumber = accountNumber;
        CustomerName = customerName;
    }

    public virtual string Deposit(double amount)
    {
        Balance += amount;
        return "Deposited";
    }

    public virtual string Withdraw(double amount)
    {
        Balance -= amount;
        return "Withdrawn";
    }

    public abstract void Transfer(string from, string to, double amount, DateTime date);
}

public class SavingAccount : BankAccount
{
    public double InterestAmount { get; set; }

    public SavingAccount(string accountNumber, string customerName, double interestAmount)
        : base(accountNumber, customerName)
    {
        InterestAmount = interestAmount;
    }

    public override string Withdraw(double amount)
    {
        // Adding interest logic for withdrawal
        if (Balance >= amount)
        {
            return base.Withdraw(amount);
        }
        else
        {
            return "Insufficient Balance!";
        }
    }

    public override void Transfer(string from, string to, double amount, DateTime date)
    {
        // Implement transfer logic for savings account
    }
}

public class CheckingAccount : BankAccount
{
    public double ServiceCharge { get; set; }

    public CheckingAccount(string accountNumber, string customerName, double serviceCharge)
        : base(accountNumber, customerName)
    {
        ServiceCharge = serviceCharge;
    }

    public override void Transfer(string from, string to, double amount, DateTime date)
    {
        // Implement transfer logic for checking account
    }
}

class AbstractClassAbstractMethod
{
    public static void Main(string[] args)
    {
        SavingAccount savingAccount = new SavingAccount("101", "Tisha", 100);
        Console.WriteLine(savingAccount.Deposit(500));
        Console.WriteLine(savingAccount.Withdraw(1000));

        CheckingAccount checkingAccount = new CheckingAccount("201", "Shagor", 200);
        Console.WriteLine(checkingAccount.Deposit(800));
        Console.WriteLine(checkingAccount.Withdraw(1000));
    }
}
