using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvenOdds
{
    class MultiplyEvenOdds
    {
        static int SumOfEven(int number)
        {
            int sumofeven = 0;
            
            while (number != 0)
            {
                int currentnum = number % 10;
                if (currentnum % 2 == 0)
                    sumofeven = sumofeven + currentnum;
                number = number / 10;
            }

            return sumofeven;
        }

        static int MultiplyEvOdds( int number)
        {
            int multiply = SumOfEven(number) * SumOfOdds(number);
            return multiply;
        }
        static int SumOfOdds(int number)
        {
            int sumofodd = 0;

            while (number != 0)
            {
                int currentnum = number % 10;
                if (currentnum % 2 != 0)
                    sumofodd = sumofodd + currentnum;
                number = number / 10;
            }

            return sumofodd;
        }

        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplyEvOdds(number));
        }
    }
}
