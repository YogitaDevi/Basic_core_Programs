using System;

namespace UC3_PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number where do you want: ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int cnt = 0; cnt <= n; cnt++) 
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
       
    }
}
