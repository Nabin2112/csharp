// write a C# program to print the sum of two numbers 

using System;

namespace Helloworld
{
    class Sum
    {
    
        public void PrintSum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum of two numbers = " + sum);
        }

         static void Main(string[] args)
        {
            Take obj = new Take();

            Console.ReadKey();
        }
    }
}
