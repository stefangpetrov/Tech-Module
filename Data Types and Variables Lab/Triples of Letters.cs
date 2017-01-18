using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

                for (int i2 = 0; i2 < n; i2++)
                {

                    for (int i3 = 0; i3 < n; i3++)
                    {
                        char a = (char)('a' + i);
                        char b = (char)('a' + i2);
                        char c = (char)('a' + i3);
                        Console.Write(a);
                        Console.Write(b);
                        Console.WriteLine(c);

                    }
                }

            }
        }
    }
}
