using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? : ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("You guessed too high.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("You guessed too low.");
            }

            Console.Write("What is your guess? : ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You guessed the number!");
    }
}