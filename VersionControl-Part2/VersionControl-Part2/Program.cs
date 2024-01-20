using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionControl_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var active = true;
            while (active)
            {
                PrintMenu();
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        RandomInteger();
                        break;
                    case "2":
                        TodaysDate();
                        break;
                    case "3":
                        RandomDinosaur();
                        break;
                    case "4":
                        RandomStringMod();
                        break;
                    case "q":
                    case "Q":
                        active = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry, please try again");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Random Integer 1-10");
            Console.WriteLine("2. Today's Date");
            Console.WriteLine("3. Display Random Dinosaur");
            Console.WriteLine("4. Random String Modification");
            Console.WriteLine("Enter q to Quit");
            Console.WriteLine("-------------------------");
        }

        static void RandomInteger()
        {

        }

        static void TodaysDate()
        {

        }

        static void RandomDinosaur()
        {

        }

        static void RandomStringMod()
        {

        }
    }
}
