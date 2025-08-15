// Write a c# program input student name and marks of 5 subject and calculate average and GPA.

using System;
class Student
{
    public static void StudenFun()
    {
        Console.WriteLine("Enter Student Name: ");
        String name = Console.ReadLine();
        double marks;
        Double sum = 0;
        Double average;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Enters Subjects Marks:");
            marks = Convert.ToDouble(Console.ReadLine());
            sum = sum + marks;
        }
        average = sum / 5;
        Console.WriteLine("The average is:" + average);
        double gpa = average / 25;
        Console.WriteLine("The GPA is:" + gpa);
        
    }
}                                                                                                                   