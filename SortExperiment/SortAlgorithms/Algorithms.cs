using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SortAlgorithms
{
    public class Algorithms
    {

        public static int[] countSort(int[] arr)
        {

            int[] count = new int[arr.Max() + 1];
            int[] sorted = new int[arr.Length];

            foreach (int x in arr)
            {
                count[x] += 1;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            foreach (int x in arr)
            {
                sorted[count[x] - 1] = x;
                count[x] -= 1;
            }

            return sorted;
        }

        // A function to do counting sort of arr[] according to  
        // the digit represented by exp.  
        private static void countSortDigit(int[] arr, int exp)
        {
            int[] output = new int[arr.Length]; // output array 
            int[] count = new int[arr.Max()];

            // Store count of occurrences in count[]  
            for (int i = 0; i < arr.Length; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains actual  
            //  position of this digit in output[]  
            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];

            // Build the output array  
            for (int i = (arr.Length) - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now  
            // contains sorted numbers according to current digit  
            for (int i = 0; i < arr.Length; i++)
                arr[i] = output[i];
        }

        // The main function to that sorts arr[] of size n using   
        // Radix Sort  
        public static void radixsort(int[] arr)
        {
            // Find the maximum number to know number of digits  
            int m = arr.Max();

            // Do counting sort for every digit. Note that instead  
            // of passing digit number, exp is passed. exp is 10^i  
            // where i is current digit number  
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSortDigit(arr, exp);
        }

        public static void Main()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            radixsort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

            int[] arr2 = { 10, 4, 3, 5, 3, 2, 1, 1 };

            arr2 = countSort(arr2);
            for (int i = 0; i < arr2.Length; i++)
                Console.Write(arr2[i] + " ");

            Thread.Sleep(60000);
        }

    }
}
