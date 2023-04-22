using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicnumber = int.Parse(userInput);
        Console.Write("What is your guess? ");
        string userguess = Console.ReadLine();
        int guessnumber = int.Parse(userguess);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(magicnumber);

       //int guessnumber = -1;

        // We could also use a do-while loop here...
        while (guessnumber != number)
        {
            Console.Write("What is your guess? ");
            guessnumber = int.Parse(Console.ReadLine());

            if ( guessnumber > number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessnumber < number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}

    
