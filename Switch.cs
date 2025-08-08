// Marks Grading using Switch statement 

using System;
using System.Runtime.CompilerServices;
class Switch
{
    static void SwitchFunc()
    {
        int marks = 65;
        switch (marks)
        {
            case int m when m >= 90:
                Console.WriteLine("Grade A+");
                break;
        }

    }
}