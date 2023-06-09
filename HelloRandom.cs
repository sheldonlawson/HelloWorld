using System;

class HelloWorldRandom
{
    static void Main()
    {
        string target = "hello world";
        Random random = new Random((int)DateTime.Now.Ticks);

        string generated = string.Empty;
        int index = 0;

        while (generated != target)
        {
            char randomChar = (char)random.Next(97, 123);  // Generate a random lowercase letter

            generated += randomChar;

            Console.Write(randomChar);

            if (randomChar == target[index])
                index++;

            if (index == target.Length)
                break;

            System.Threading.Thread.Sleep(100);  // Pause for 100 milliseconds
        }

        Console.WriteLine("\nHello, World!");
    }
}
