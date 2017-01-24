using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOFTwoValues
{
    class GreaterOfTwoNums
    {
        static int GreaterInt(int first, int second)
        {
            if (first >= second)
                return first;
            else
                return second;
        }

        static char GreaterChar(char first, char second)
        {
            if (first >= second)
                return first;
            else 
                return second;
        }

        static string GreaterString(string first, string second)
        {
            if(first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
                return second;
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if(type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GreaterInt(first, second));

            }

            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GreaterChar(first, second));

            }

            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                Console.WriteLine(GreaterString(first, second));

            }

        }
    }
}
