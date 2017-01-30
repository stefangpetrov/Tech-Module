using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxMethod
    {
        //Getting the greater of two numbers
        static int GetMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if(number1 > number2 && number3>number2)
                Console.WriteLine(GetMax(number1, number3));
            
            else if(number1>number3 && number2>number3)
                Console.WriteLine(GetMax(number1, number2));

            else if(number2 > number1 && number3 > number1)
                Console.WriteLine(GetMax(number2, number3));
        }
    }
}
