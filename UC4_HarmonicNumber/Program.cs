using System;

namespace UC4_HarmonicNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n;
            double s = 0.0;
            Console.Write("Calculate the harmonic series.......");
 

            Console.Write("\nInput the number of terms : ");
           
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHarmonic Series : ");
            for (i=1;i<=n;i++)
            {
               
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\n{0}th Harmonic Values : {1} \n", n,s);
        }
    }
}
