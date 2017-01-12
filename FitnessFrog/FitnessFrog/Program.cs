using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {
            double runningTotal = 0;

            string name = "";

            Console.WriteLine("Welcome to Fitness Frog!");

            //Ask the user for their name. This loop repeats until user enters appropriate name
            while (true)
            {
                Console.WriteLine("\n\nTo personalize your experience please enter your name:");

                name = Console.ReadLine();
                if (name.All(Char.IsLetter) == false)
                {
                    Console.WriteLine("\n\"{0}\" is not an acceptable entry. Your name must contain only letters A-Z.", name);
                }
                else if (name.All(Char.IsLetter) == true)
                {
                    break;
                }
            }
            
            while (true)
            {
                // Prompt user for minutes exercised 
                Console.Write("\n\nEnter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                
                try
                {
                    double minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine("{0} is not an acceptable value.", minutes);
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("\nBetter than nothing {0}, am I right?", name);
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("\nWay to go {0}!", name);
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("\nWow {0}, you must be a ninja warrior in training!", name);
                    }
                    else
                    {
                        Console.WriteLine("\nOkay {0}, now you're just showing off!", name);
                    }

                    runningTotal += minutes;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry {0} but that is not a valid input", name);
                    continue;
                } 
                    
                    
                // Display total minutes exercised to the screen 
                Console.WriteLine("You've exercised for {0} minutes.", runningTotal);
                
                // Repeat until user quits
            }

            Console.WriteLine("Goodbye");
        }
    }
}
