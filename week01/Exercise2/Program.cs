using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade? : ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";
        int remainder = grade % 10;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
    
    if (remainder >= 7 && letter != "A" && letter != "F")
        {
            letter += "+";
        }
        else if (remainder < 3 && letter != "F")
        {
            letter += "-";
        }
    if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
        Console.WriteLine($"Your letter grade is: {letter}");
    }
}