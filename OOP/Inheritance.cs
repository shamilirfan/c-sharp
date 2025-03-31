using System;

// 14
// Types of Inheritance :-
// 1. Single Inheritance
// 2. Hierarchical Inheritance
// 3. Multi Level Inheritance (not supported in c#)

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

    public SavingAccount(string accountNumber, string customerName, double interestAmount)
    {
        this.accountNumber = accountNumber;
        this.customerName = customerName;
        this.interestAmount = interestAmount;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(
            $"Account Number: {accountNumber}, Customer Name: {customerName}, Interest Amount: {interestAmount}, Balance: {balance}"
        );
    }
}

class CheckingAccount : BankAccount
{
    public double serviceCharge { get; set; }

    public CheckingAccount(string accountNumber, string customerName, double serviceCharge)
    {
        this.accountNumber = accountNumber;
        this.customerName = customerName;
        this.serviceCharge = serviceCharge;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(
            $"Account Number: {accountNumber}, Customer Name: {customerName}, Service Charge: {serviceCharge}, Balance: {balance}"
        );
    }
}

class Inheritance
{
    public static void Main(string[] args)
    {
        SavingAccount anika = new SavingAccount("101", "Anika", 20.24);
        anika.Deposit(1000);
        anika.Withdraw(400);
        anika.DisplayInfo();

        CheckingAccount ripon = new CheckingAccount("101", "Ripon", 68.67);
        ripon.Deposit(200000);
        ripon.Withdraw(967);
        ripon.DisplayInfo();
    }
}
