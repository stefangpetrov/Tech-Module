using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArray
{
    class ReverseAnArray
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int j = n - 1; j >= 0; j--)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
