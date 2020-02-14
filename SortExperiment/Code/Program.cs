using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SortAlgorithms;

namespace Code
{
    class Program
    {
        public static void Main()
        {

            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            Algorithms.radixsort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

            int[] arr2 = { 10, 4, 3, 5, 3, 2, 1, 1 };

            arr2 = Algorithms.countSort(arr2);
            for (int i = 0; i < arr2.Length; i++)
                Console.Write(arr2[i] + " ");

            Thread.Sleep(60000);
        }
    }
}

