﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            

            for (int i = input.Length - 1; i >= 0; i--)
            {
                
                Console.Write(input[i]);
                
            }
            
           

        }
    }
}
