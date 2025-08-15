
using System;
public class Nstudent
{
    public static void SteFun()
    {
        Console.WriteLine("Enters Students Data:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i<=n; i++)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            break;
        }
        double marks;
        Double sum = 0;
        Double average;
        for (int i = 1; i<=5; i++)
        {
            Console.WriteLine("Enters Subjects Marks:");
            marks = Convert.ToDouble(Console.ReadLine());
            sum = sum + marks;
        }
        average = sum / 5;
        Console.WriteLine("The average is" +average);
        double gpa = average / 25;
        Console.WriteLine("The GPA is " +gpa);
        }
    }
