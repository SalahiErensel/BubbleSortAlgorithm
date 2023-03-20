using System;

namespace BubbleSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, tmp;
            int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (i = 0; i < array.Length; i++)
            {
                for (j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
