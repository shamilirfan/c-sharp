using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

class Dictionary1
{
    public static void Main(string[] args)
    {
        /* In C#, Dictionary is a generic collection which is generally used to 
           store key/value pairs. It is similar to the non generic Hashtable. 
           The dictionary of C# is same as English dictionary.
        */

        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("Name", "Your name is the identifier by which you are known or addressed.");
        dictionary.Add("City", "A city is a relatively large and permanent human settlement. ");

        Console.WriteLine($"{dictionary["Name"]}");

        foreach (KeyValuePair<string, string> item in dictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

    }
}