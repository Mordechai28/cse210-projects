using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.Write("Enter a number: ");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? : ");
        int guess = int.Parse(Console.ReadLine());
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? : ");
            guess = int.Parse(Console.ReadLine());
         if (guess > magicNumber)
        {
            Console.WriteLine("You guessed too high.");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("You guessed too low.");
        }
        else
        {
            Console.WriteLine("You guessed the number!");
        }
    }}
    