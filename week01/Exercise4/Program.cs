using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        names.Add("Agacia");
        names.Add("Markiss");
        names.Add("Zer");

        names.Remove("Zer");
        names[2] = "Daniel";
        Console.WriteLine(names.Count);
        foreach (string name in names)
        {
        Console.WriteLine(name);
        }
    }
}