using System;

namespace UC6_Compute
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dividend is : ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisor is : ");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is = " + quotient);
            Console.WriteLine("Remainder is = " + remainder);
            Console.ReadLine();
        }
    }
}
