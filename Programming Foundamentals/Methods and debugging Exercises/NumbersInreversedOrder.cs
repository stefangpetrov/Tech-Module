using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInreversedOrder
{
    class NumbersInreversedOrder
    {
        static void Main()
        {
            string n = Console.ReadLine();
            Reversenumber(n);
        }

        static void Reversenumber(string n)
        {
            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.Write(n[i]);
            }

        }
    }
}
