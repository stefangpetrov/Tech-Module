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

            int allpics = int.Parse(Console.ReadLine());
            int filtertime = int.Parse(Console.ReadLine());
            int filterfactor = int.Parse(Console.ReadLine());
            int uploadtime = int.Parse(Console.ReadLine());

            int useful = allpics * (filterfactor/100);
            int totaltime = allpics * filtertime + useful * uploadtime;

            TimeSpan time = TimeSpan.FromSeconds(totaltime);
            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", time);
        }
    }
}
