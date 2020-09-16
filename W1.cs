using System;

namespace CIT365_F2020_NewellBrycen
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string location;
            DateTime date = DateTime.Today;
            string dateString;
            DateTime Christmas = new DateTime(2020, 12, 25);
            int daysToChristmas;


            name = "Brycen Newell";
            location = "Oklahoma City, Oklahoma";
            dateString = date.ToString("d");
            daysToChristmas = ((TimeSpan)(Christmas - date)).Days;

            //Output for 3, 4, and 5
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"\nI am from {location}.");
            Console.WriteLine($"\nToday is {dateString}.");
            Console.WriteLine($"\nThere are only {daysToChristmas} days left until Christmas!");

            //Section 2.1 in C# Programming Yellow Book

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Provide appropriate text labels when requesting dimensional input

            Console.WriteLine("\nWhat is the width in metres?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("You said that the width is: " + width + " metres.");

            Console.WriteLine("\nWhat is the height in metres?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            Console.WriteLine("You said that the height is: " + height + " metres.");


            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " + woodLength + " feet.");
            Console.WriteLine("\nThe area of the glass is " + glassArea + " square feet.");

            Console.WriteLine("\nType any key to exit.");
            _ = Console.ReadKey();
        }
    }
}