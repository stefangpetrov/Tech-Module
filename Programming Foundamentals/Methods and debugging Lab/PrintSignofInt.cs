﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_an_Integer
{
    class PrintSignofInt
    {

        static void PrintSign(int number)
        {
            if(number>0)
                Console.WriteLine("The number {0} is positive.", number);
            else if(number<0)
                Console.WriteLine("The number {0} is negative.", number);
            else
                Console.WriteLine("The number {0} is zero.", number);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
