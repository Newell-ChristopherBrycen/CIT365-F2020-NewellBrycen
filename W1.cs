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
           
        }
    }
}