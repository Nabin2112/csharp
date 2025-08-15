// Write a C# program to compute the sum of two given integers. if two values are the same, return the triple of their sum.


using System;
public class Trisum
{
    public static void Tri()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result;

        if (num1 == num2)
        {
            result = 3 * (num1 + num2);
        }
        else
        {
            result = num1 + num2;
        }

        Console.WriteLine($"Result: {result}");
    }
     
}