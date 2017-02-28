using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var final = int.Parse(Console.ReadLine());

            for (int i = start; i <= final; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}
