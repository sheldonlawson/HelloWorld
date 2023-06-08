using System;

public class HelloWorld
{
    public static void Main()
    {
        // Mathematical calculations
        int result = ((((3 * 2) << 1) | 6) & (5 ^ 7)) + (int)Math.Pow(2, 3) - 1;

        // Convert the result to a binary string
        string binaryString = Convert.ToString(result, 2);

        // Reverse the binary string
        char[] reversedChars = binaryString.ToCharArray();
        Array.Reverse(reversedChars);
        string reversedBinaryString = new string(reversedChars);

        // Convert the reversed binary string back to an integer
        int reversedResult = Convert.ToInt32(reversedBinaryString, 2);

        // Convert the reversed result to a hexadecimal string
        string hexadecimalString = reversedResult.ToString("X");

        // Iterate over the hexadecimal string and print the corresponding ASCII characters
        foreach (char c in hexadecimalString)
        {
            Console.Write((char)(c + 15));
        }

        Console.WriteLine();
    }
}
