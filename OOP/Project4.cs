using System;

class Studen
{
    private string? _name; // _ is convention for private variable name.
    private DateTime _dateOfBirth;
    private int _rollNumber;
    public string? Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("name can not be null or empty!");
            }
            _name = value;
        }
    }
    public DateTime DateOfBirth
    {
        get
        {
            return _dateOfBirth;
        }
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Date of birth can not be in the future.");
            }
            _dateOfBirth = value;
        }
    }
    public int RollNumber
    {
        get
        {
            return _rollNumber;
        }
        set
        {
            _rollNumber = value;
        }
    }
    public Studen(string name, DateTime dateOfBirth, int rollNumber)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }
    private int CalculateAge()
    {
        if (DateOfBirth == null)
        {
            return 0;
        }
        int age = DateTime.Now.Year - DateOfBirth.Year;
        return DateTime.Now < DateOfBirth.AddYears(age) ? age - 1 : age;
    }
    public int Age
    {
        get
        {
            return CalculateAge();
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Date of birth: {DateOfBirth.ToShortDateString()}, Age: {Age}, Roll number: {RollNumber}");
    }
}
class Project4
{
    public static void Main(string[] args)
    {
        try
        {
            Studen s1 = new Studen("Alex", new DateTime(2000, 3, 24), 1);
            Studen s2 = new Studen("Bob", new DateTime(1990, 7, 8), 2);
            Studen s3 = new Studen("Linda", new DateTime(2002, 9, 15), 3);

            s1.DisplayInfo();
            s2.DisplayInfo();
            s3.DisplayInfo();
        }
        catch (Exception error)
        {
            Console.WriteLine($"{error.Message}");
        }
    }
}




