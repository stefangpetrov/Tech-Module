using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;
                while (digits > 0)
                {

                    sumOfDigits = sumOfDigits + (digits % 10);
                    digits = digits / 10;
                }
                if (sumOfDigits != 5 && sumOfDigits != 7 && sumOfDigits != 11)
                {
                    Console.WriteLine(i + " -> False");
                }
                else
                    Console.WriteLine(i + " -> True");

            }
        }
    }
}
