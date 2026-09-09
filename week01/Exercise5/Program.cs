using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        string name = GetName();
        Console.WriteLine($"Hello {name}!");

        string greeting = CreateGreeting(name);
        Console.WriteLine(greeting);

        DisplayWelcome();
        int number = PromptUserNumber();
        Console.WriteLine($"You entered the number: {number}");
        int squared = SquareNumber(number);
        DisplayResult(number, squared);
    }
     static string GetName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
     static string CreateGreeting(string name)
        {
            return $"Hello {name}, welcome to the program!";
        }
     static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

     static int PromptUserNumber()
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }


     static int SquareNumber(int number)
        {
            return number * number;
        }

     static void DisplayResult(int number, int squared)
        {
            Console.WriteLine($"The square of {number} is {squared}");
        }
}
