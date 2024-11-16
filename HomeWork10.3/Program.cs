using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input words");

        string input = Console.ReadLine();

        string result = input.Replace(" ", "");
        
        Console.WriteLine(result);
    }
}
