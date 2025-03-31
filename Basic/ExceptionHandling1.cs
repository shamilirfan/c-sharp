using System;

class ExceptionHandling1
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write($"Enter number 1 = ");
            string input1 = Console.ReadLine() ?? "";
            // error throwing
            if (string.IsNullOrEmpty(input1))
            {
                throw new ArgumentNullException("input can not be null or empty");
            }
            int num1 = Convert.ToInt32(input1);

            Console.Write($"Enter number 2 = ");
            string input2 = Console.ReadLine() ?? "";
            // error throwing
            if (string.IsNullOrEmpty(input2))
            {
                throw new ArgumentNullException("input can not be null or empty");
            }
            int num2 = Convert.ToInt32(input2);

            if (num2 > 100)
            {
                throw new ArgumentException("num2 can not be divide greater than 100");
            }

            int result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}\n");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Number was too big or small for Int32");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Invalid input! please valid integer");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine($"can not divide by zero");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine($"input can not be null or empty");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"{e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
        finally
        {
            Console.WriteLine($"Goodbye!!!");
        }
    }
}