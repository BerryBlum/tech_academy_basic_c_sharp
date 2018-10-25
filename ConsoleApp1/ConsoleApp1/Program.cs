using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("What's ypur name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
        Console.Beep();
        Console.Read();
    }
}
