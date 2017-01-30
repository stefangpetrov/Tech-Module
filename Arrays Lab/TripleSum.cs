using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();            
            string[] items = values.Split(' ');
            int[] array = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
                array[i] = int.Parse(items[i]);

            bool Istheretriplesum = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array.Contains(array[i] + array[j]))
                    {
                        Console.WriteLine(array[i] + " + " + array[j] + " == " + (array[i] + array[j]));
                        Istheretriplesum = true;
                    }

                }
            }

            if (!Istheretriplesum)
                Console.WriteLine("No");

        }
    }
}
