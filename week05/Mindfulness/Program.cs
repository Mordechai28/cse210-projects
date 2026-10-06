// Exceeding Requirements:
// 1. Guaranteed No-Repeat Prompts & Questions: Implemented non-repetitive selection logic in ReflectionActivity 
//    so that no questions or prompts repeat within a session until all available items have been used at least once.
// 2. Activity Session Log Counter: Added a activity counter tracked in Program.cs that reports total mindfulness sessions completed before quitting.

using System;

class Program
{
    static void Main(string[] args)
    {
        int totalSessionsCompleted = 0;
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    totalSessionsCompleted++;
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    totalSessionsCompleted++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    totalSessionsCompleted++;
                    break;

                case "4":
                    keepRunning = false;
                    Console.WriteLine($"\nThank you for taking time for yourself today!");
                    Console.WriteLine($"Total mindfulness sessions completed: {totalSessionsCompleted}");
                    break;

                default:
                    Console.WriteLine("\nInvalid selection. Please enter a number 1-4.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}