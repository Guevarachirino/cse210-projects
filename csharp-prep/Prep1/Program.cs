using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your lastname ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {name}, {lastname}.");
    }
}