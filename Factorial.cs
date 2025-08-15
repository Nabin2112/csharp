// write a C# to find the factorial input by user.

using System;
public class Factorial
{
    public static void FactorialFucn()
    {
        int i;
        int num;
        int fact = 1;
        Console.WriteLine("enter the number:");
        num = int.Parse(Console.ReadLine());
        for ( i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
             Console.WriteLine($"the factorial of {num} is {fact}");
        }
 
       
    }
   