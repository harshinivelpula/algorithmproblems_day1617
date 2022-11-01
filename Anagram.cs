using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmproblems
{
    internal class Anagram
    {
        public static void Display()
        {
            string str1 = "heater";
            string str2 = "reheat";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("it is an anagram");
            }
            else
            {
                Console.WriteLine("it is not an anagram");
            }
        }
    }
}
