using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOFLastDigit
{
    class EnglishNameOFLastDigit
    {
        static string GetName(long number)
        {
            string name;
            if (Math.Abs(number % 10) == 1)
                name = "one";
            else if (Math.Abs(number % 10) == 2)
                name = "two";
            else if (Math.Abs(number % 10) == 3)
                name = "three";
            else if (Math.Abs(number % 10) == 4) 
                name = "four";
            else if (Math.Abs(number % 10) == 5)
                name = "five";
            else if (Math.Abs(number % 10) == 6)
                name = "six";
            else if (Math.Abs(number % 10) == 7)
                name = "seven";
            else if (Math.Abs(number % 10) == 8)
                name = "eight";
            else if (Math.Abs(number % 10) == 9)
                name = "nine";
            else 
                name = "zero";
            return name;
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(GetName(number));

        }
    }
}
