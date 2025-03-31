using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Player
{
    public string name;
    public int age;

    public Player(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class ListOfObjects
{
    public static void Main(string[] args)
    {
        List<Player> players = new List<Player>();

        players.Add(new Player("Sakib", 34));
        players.Add(new Player("Mashrafee", 42));

        foreach (Player player in players)
        {
            Console.WriteLine($"{player.name} is {player.age} years old.");
        }
    }
}
