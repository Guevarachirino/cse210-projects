using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        journal        journal = new journal();
        int            menuanswer = 0;

        List<string>   menu = new List<string>
        {
            "Please select one of the following choises: ",
            "1. write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do?"

        };


        while (menuinput !=5)
        {
            foreach (string menuanswer in menu)
            {
                Console.WriteLine(menuanswer);
            }

            menuinput = int.Parse(Console.ReadLine());

            switch
        }
        
    }
}