﻿using System;

namespace UC8_EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
          int n;
          Console.Write("Enter the number = ");
          n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                    Console.WriteLine(n + " is even");
            else
                    Console.WriteLine(n + " is odd");

                Console.ReadKey();
            }
        }
    }
