using System;

namespace UC5_Factors
{
    public class factors
    {
       public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please enter the number : ");
            a = Convert.ToInt32(Console.ReadLine());
            for (b=2; a>1; b++)
             if (a % b == 0)
             {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} Times");
             }

        }
    }
}
