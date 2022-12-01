using System;

namespace UC10_LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st number is : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2nd number is : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3rd number is : ");
            int num3 = int.Parse(Console.ReadLine());
            
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("1st Number is the largest! ");
                }
                else
                {
                    Console.Write("3rd Number is the largest! ");
                }
            }
            else if (num2 > num3)
                Console.Write("2nd Number is the largest!");
            else
                Console.Write("3rd Number is the largest!");
        }
    }
}
