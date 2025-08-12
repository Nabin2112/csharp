// write a C# to find the factorial input by user.

using System;
class Factorial
{
   public static void FactorialFucn()
    {
        int num;
        int fact = 1;
        Console.WriteLine("enter the number:");
        num = int.Parse(Console.ReadLine());
        int i = 1;
        while (i <= num)
        {
            fact*=i;
            i++;
        }
        Console.WriteLine($"the factorial of {num} is{fact}");
    }
}