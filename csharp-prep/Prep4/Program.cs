using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> newnumber = new List<int>();
        int number = -1;
        while (number != 0)
        {
            
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                newnumber.Add(number);
            }
        }
            

        }

    }
