using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    class ReverseanArrayofStrings
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
