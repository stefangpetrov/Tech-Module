using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {

            double allpics = double.Parse(Console.ReadLine());
            double filtertime = double.Parse(Console.ReadLine());
            double filterfactor = double.Parse(Console.ReadLine());
            double uploadtime = double.Parse(Console.ReadLine());

            double useful = Math.Ceiling(allpics * filterfactor / 100);
            double totaltime = allpics * filtertime + useful * uploadtime;

            TimeSpan time = TimeSpan.FromSeconds(totaltime);
            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", time);
        }
    }
}
