using System;

namespace UC7_Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Number is a : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd Number is b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;       
            b = a - b;       
            a = a - b;    
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
