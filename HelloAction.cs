using System;

public class HelloWorld
{
    public static void Main()
    {
        Action<string> print = s => { foreach (char c in s) Console.Out.Write(c); };

        string hello = "Hello";
        string space = " ";
        string world = "World!";

        print(hello);
        print(space);
        print(world);

        Console.Out.Flush();
    }
}
