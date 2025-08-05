// Write a C# program to swap two numbers.
using System;
public class Swap
{
   public  void Ma()
    {
        int a = 10, b = 20;
        Console.WriteLine("Before swapping");
        Console.WriteLine("Value of a = {0} and b = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After swapping");
        Console.WriteLine("Value of a = {0} and b = {1}", a, b);
        }
      

    }
