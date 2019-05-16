using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta4
{
    class Program
    {
        static void Main(string[] args)
        {
             class SelectionSort
        {
            public static void selectionSort<T>(ref T[] array) where T : IComparable
            {
                for (int i = 0; i < array.Length; i++)
                {
                    T key;

                    key = array[i];
                    int min = key;
                    int minId = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < min)
                        {
                            min = array[j];
                            minId = j;
                        }
                    }
                    // swapping
                    int temp = array[i];
                    array[i] = min;
                    array[minId] = temp;
                }
            }
        }
    }
    }
}
