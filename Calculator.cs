// write a c# program to make Calculator using Switch statement.

using System;
public class Calculator
{
    public void Cal()
    {
        Console.WriteLine("Enters two number");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter an operator '+','-','*','/'");
        Char opr = Char.Parse(Console.ReadLine());

        double result = 0;
        switch (opr)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("error");
                    break;
                }
                result = num1 / num2;
                break;

            default:
                Console.WriteLine("invalid");
                break;
        }
        Console.WriteLine($"{result}");
    }
}

