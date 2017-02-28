﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class TriangleOfNumbers
    {

        static void Triangle(int number)
        {
            
            for (int i = 1; i <= number; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= number; i++)
            {

                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
    }
}
