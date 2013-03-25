using System;

public class Program
{
    public static void SayHello(string name)
    {
        Console.WriteLine("Hello {0}!", name);
    }

    public static void Main()
    {
        SayHello(Console.ReadLine());
    }
}
