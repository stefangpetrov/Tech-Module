using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class FilledSquare
    {
        static void Square(int number)
        {
            Console.WriteLine(new string('-', 2*number));
            for (int i = 0; i < number-2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= number*2 - 2; j++)
                {
                    if(j%2 == 1)
                        Console.Write("\\");
                    else
                        Console.Write("/");
                }
                Console.WriteLine("-");
            }

            Console.WriteLine(new string('-', 2 * number));

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Square(n);
        }
    }
}
