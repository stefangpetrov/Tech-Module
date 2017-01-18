using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = double.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(persons / capacity));

        }
    }
}
