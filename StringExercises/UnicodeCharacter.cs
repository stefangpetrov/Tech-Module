using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (char c in text)
            {
                Console.Write("\\u{0:x4}", (int)c);
            }
        }
    }
}
