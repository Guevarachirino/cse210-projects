using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Journal        journal = new Journal();
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


        while (menuanswer !=5)
        {
            foreach (string menuinput in menu)
            {
                Console.WriteLine(menuinput);
            }

            menuanswer = int.Parse(Console.ReadLine());

            switch (menuanswer)
            {
                case 1: 
                    journal.CreateJournal();
                    break;

                case 2:
                    journal.DeployJournal();
                    break;
                


            }
        }
        
    }
}