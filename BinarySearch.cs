using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmproblems
{
    internal class BinarySearch
    {
        public void BinarySearchIterative(string userInput)
        {
            string[] strInputArray = { " V ", " A " };
            int minimum = 0, middle = 0, result = -1;
            int maximum = strInputArray.Length - 1;

            Console.Write("array values is");
            for (int i = 0; i <= maximum; i++)
            {
                Console.WriteLine(strInputArray[i]);
            }
            Console.WriteLine(" ");


            while (minimum <= maximum)
            {
                middle = minimum + (minimum - 1) / 2;

                if (userInput.Equals(strInputArray[middle]))
                {
                    result = 0;
                }
                if (result == 0)
                {
                    Console.WriteLine("matching");
                }

                int val = Convert.ToInt32(userInput.CompareTo(strInputArray[middle]));

                if (val == 1)
                {
                    minimum = middle + 1;
                    result = 1;
                }
                else
                {
                    maximum = middle - 1;
                    result = 1;
                }
            }

            if (result == -1)
            {
                Console.WriteLine("string not found");
            }
            else if (result == 1)
            {
                Console.WriteLine("string is found");
            }

        }
    }
}
