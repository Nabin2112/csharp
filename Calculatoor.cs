// Write a c# program to make simple calsulator in  a continuous loop.

using System;
class Calculatoor
{
    public static void CalculatoorFun()
    {
        while (true)
        {
            Console.WriteLine("\n Simple Calcu");
            Console.WriteLine("Enter first Number:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator '+','-','*','/'");
            char op = Console.ReadLine()[0];

            double result = 0;
            bool validOperation = true;

            switch (op)
            {

                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;

                case '/':
                    if (b == 0)
                        result = a / b;
                    else
                    {
                        Console.WriteLine("Error Division by Zero");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("invalid Operator!!");
                    validOperation = false;
                    break;
            }
            if (validOperation)
            {
                Console.WriteLine($"Result:{result}");
                Console.Write("\n Do you want to continue? (y/n):");
                String Choice = Console.ReadLine().ToLower();
                if (Choice != "y")
                    break;
            }

            Console.WriteLine("Calculator Closed");
}
    }
}