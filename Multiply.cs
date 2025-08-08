// Write a c# program to print multiplication using Nested while loop.

using System;
class Multiply
{
   public static void MulFunc()
    {
        int row = 2;
        while (row < 4)
        {
            int col = 1;
            while (col < 10)
            {
                Console.WriteLine($"{row}x{col}={row * col}");
                col++;
            }
            Console.WriteLine();
            row++;
    }
    }
}