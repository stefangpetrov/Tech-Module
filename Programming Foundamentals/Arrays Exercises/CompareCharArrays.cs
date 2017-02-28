using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            int minLen = Math.Min(first.Length, second.Length);
            int count = 0;

            for (int i = 0; i < minLen; i++)
            {
                if(first[i] < second[i])
                {
                    Console.WriteLine(String.Join("", first));
                    Console.WriteLine(String.Join("", second));
                    break;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine(String.Join("", second));
                    Console.WriteLine(String.Join("", first));
                    break;
                }

                count++;


            }

            if(count == minLen)
            {
                if (first.Length > second.Length)
                {
                    Console.WriteLine(String.Join("", second));
                    Console.WriteLine(String.Join("", first));
                }
                else
                {
                    Console.WriteLine(String.Join("", first));
                    Console.WriteLine(String.Join("", second));
                }
            }


        }
    }
}
