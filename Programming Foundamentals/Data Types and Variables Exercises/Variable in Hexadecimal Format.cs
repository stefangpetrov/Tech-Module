﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInHex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(numberInHex, 16));
        }
    }
}
