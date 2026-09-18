// Exceeding Requirements:
// 1. Only selects words to hide that are NOT already hidden (avoiding re-hiding already hidden words).
// 2. Implemented a library of multiple scriptures (both single and multi-verse) and presents one at random upon execution.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Scripture library for random selection
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Ether", 12, 27),
                "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble;"
            )
        };

        // Pick a random scripture from the library
        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide 3 words per turn
            scripture.HideRandomWords(3);
        }
    }
}