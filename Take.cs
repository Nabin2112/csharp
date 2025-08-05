// Taking 3 subject number as input from user and calculate average and garde using switch expression.
using System;
class Take
{
    static void Man()
    {
        Console.WriteLine("Enter first subject marks: ");
        int sub1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second subject marks: ");
        int sub2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third subject marks: ");
        int sub3 = Convert.ToInt32(Console.ReadLine());
        double avg = (sub1 + sub2 + sub3) / 3.0;
        string grade = sub1 switch
        {
            >= 90 => "A+",
            >= 80 => "B+",
            >= 70 => "C+",
            >= 60 => "D+",
            _ => "F"
        };
        Console.WriteLine($"Average of three subjects is {avg} and grade is {grade}");
  
    }        

        }


    
   


