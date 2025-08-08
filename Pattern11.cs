// To achieve the following pattern


using System;
namespace CSharp
{
class Pattern11
{
  public static  void PatternFunction()
    {
        int r = 1;
        while (r <= 5)
        {
            int c = 1;
            while (c <= r)
            {
                Console.Write("*");
                c++;
            }
            Console.WriteLine();
            r++;
        }
    }
}
    
}
