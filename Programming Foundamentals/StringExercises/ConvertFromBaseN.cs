using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var number = BigInteger.Parse(input[1]);
            var system = int.Parse(input[0]);            

            var numberAsString = number.ToString();
            BigInteger sum = 0;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                var current = int.Parse(numberAsString[numberAsString.Length - 1 - i].ToString());

                sum += current * (BigInteger)Math.Pow(system, i);


            }

            Console.WriteLine(sum);
        }
    }
}
