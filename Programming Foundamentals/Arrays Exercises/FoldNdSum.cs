using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldNSum
{
    class FoldNdSum
    {
        static void Main(string[] args)
        {



            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
             
            
            int length = array.Length;
            int k = array.Length / 4;
            int[] firstrow = new int[2*k];

            int a = 1;
            for (int i = 0; i < k; i++)
            {
                
                firstrow[i] = array[k - a];
                a++;


            }

            int b = 1;
            for (int i = k; i < firstrow.Length; i++)
            {
                firstrow[i] = array[4*k - b];
                b++;

            }

            int c = 0;
            for (int i = k; i < 3*k; i++)
            {
                Console.Write(array[i] + firstrow[c] + " ");
                c++;
            }

           


        }
    }
}
