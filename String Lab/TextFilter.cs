using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {

            string[] replacing = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);


            var input = Console.ReadLine();

            foreach (var word in replacing)
            {
                if(input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(input);
        }
    }
}
