using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmproblems
{
    internal class searchsort
    {
        public static void Display()
        {
            static void selectionSort(int[] array)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    int min = array[i];
                    int minId = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < min)
                        {
                            min = array[j];
                            minId = j;
                        }
                    }
                    int temp = array[i];
                    array[i] = min;
                    array[minId] = temp;
                }

            }


        }
    }
}
