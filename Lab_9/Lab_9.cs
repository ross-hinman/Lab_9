using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var information = new List<List<string>>
            {
                (new List<string>() { "Benjamin Curry", "Pam Carson", "Dianne Neal", "Dana Mcdaniel", "Lee Gonzales", "Phil Mendez", "Irma Garner", "Marguerite Kelly", "Rosemary Garza", "Jesse	Bass", "Marcella Taylor", "Cristina Wilkerson", "Margarita Morris", "Bill Tucker", "Don Morales", "Gordon Sims", "Jo Bush", "Elaine Casey", "Marty Mcgee", "Ebony Becker"}),
                (new List<string>() { "Boston", "New York", "Lansing", "Austin", "San Jose", "Detroit", "Nashville", "Columbus", "Denver", "Las Vegas", "Chicago", "Flint", "Petoskey", "Grand Rapids", "Tampa Bay", "New Orleans", "San Antonio", "Madison", "Seattle", "Grand Haven" }),
                (new List<string>() { "Pizza", "PB&J", "Chicken Noodle Soup", "Bread", "BBQ Ribs", "Spaghetti", "Butter", "Tacos", "Salad", "Sweet and Sour Chicken", "Rice", "Broccoli", "Skittles", "Beans and Rice", "Honey-baked Ham", "Corn on the cob", "Ice Cream", "Pickles", "Cereal", "Grilled Cheese"})
            };
            var names = information[0];
            var cities = information[1];
            var food = information[2];

            bool repeat = true;
            Console.WriteLine("Welcome to our C# Class.");
            do
            {
                int personIndex = PersonPicker()-1;                
                GetInfo(personIndex, names, cities, food);
                repeat = Repeat(repeat);         
            } while (repeat == true);
        }

        public static int PersonPicker()
        {
            bool repeat = true;
            
            do
            {
                Console.WriteLine("Which student would you like to learn about? (enter a number: (1-20):");
                int personIndex1 = Convert.ToInt16(Console.ReadLine());
                try
                {
                    if (personIndex1 > -1 && personIndex1 < 21)
                    {
                        return personIndex1;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 and 20.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number between 1 and 20.");   
                }
            } while (repeat == true);
            return 0;
        }

        public static void GetInfo(int personIndex, List<string> names, List<string> cities, List<string> food)
        {
            Console.WriteLine($"Student {personIndex + 1} is {names[personIndex]}.");
            Console.WriteLine($"What would you like to know about {names[personIndex].ToString().Split(' ')[0]}? (Enter \"hometown\" or \"favorite food\")");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "hometown":
                    {
                        Console.WriteLine($"{names[personIndex].ToString().Split(' ')[0]} is from {cities[personIndex]}.");
                        break;
                    }
                case "favorite food":
                    {
                        Console.WriteLine($"{names[personIndex].ToString().Split(' ')[0]}'s favorite food is {food[personIndex]}.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid input.");
                        break;
                    }
            }
        }

        public static bool Repeat(bool repeat)
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string again = Console.ReadLine();
            if (again == "y")
            {
                return  true;
            }
            else 
            {
                Console.WriteLine("Thanks!");
                return false;
            }
        }
    }
}