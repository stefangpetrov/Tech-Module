﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            r = Math.PI * r * r;
            Console.WriteLine("{0:f12}", r);
        }
    }
}
