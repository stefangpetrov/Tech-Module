using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {

            char[] separators = new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' '};

            var words = Console.ReadLine().ToLower().Split(separators).ToList();
            
            var result = words.Where(word => word != "").Where(word => word.Length <5 ).OrderBy(word => word).Distinct().ToList();

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
