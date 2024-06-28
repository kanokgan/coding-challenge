using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length == 0 ? "Hello World!" : $"Hello {args[0]}!");
    }
}
