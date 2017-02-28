using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWordsByCasing
{
    class SplitWordsByCasing
    {
        static void Main(string[] args)
        {
            var separators = new char[] {',', ';', ':', '.', '!','(', ')',
                '"', '\'', '\\', '/', '[', ']', ' ' };

            var words = Console.ReadLine().Split(separators, 
                StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowercase = new List<string>();
            var mixedcase = new List<string>();
            var uppercase = new List<string>();


            for (int i = 0; i < words.Count; i++)
            {
                var current = words[i];
                int lowercount = 0;
                int uppercount = 0;
                for (int j = 0; j < current.Length; j++)
                {
                    char letter = current[j];
                    if (letter >= 'a' && letter <= 'z')
                        lowercount++;
                    else if (letter >= 'A' && letter <= 'Z')
                        uppercount++;

                }
                if (lowercount == current.Length)
                    lowercase.Add(current);
                else if (uppercount == current.Length)
                    uppercase.Add(current);
                else
                    mixedcase.Add(current);


            }

            Console.WriteLine("Lower-case: " + String.Join(",", lowercase));

            Console.WriteLine("Mixed-case: " + String.Join(",", mixedcase));
            
           
            Console.WriteLine("Upper-case: " + String.Join(",", uppercase));
            

        }
    }
}
