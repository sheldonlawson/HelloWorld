using System;

class Program
{
    static void Main()
    {
        string greeting = new string(new[] { (char)(72 + 7), (char)(101 - 2), (char)(108 * 2), (char)(111 + 1), (char)(44 + 1),
            (char)(32 + 6), (char)(87 - 1), (char)(111 + 1), (char)(114 - 1), (char)(108 * 2), (char)(100 + 1), (char)(33 - 1) });

        Console.WriteLine(greeting);
    }
}
