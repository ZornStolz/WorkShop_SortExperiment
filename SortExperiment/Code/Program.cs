using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Code
{
    class Program
    {


        // A function to do counting sort of arr[] according to  
        // the digit represented by exp.  
        public static void countSortDigit(int[] arr, int exp)
        {
            int[] output = new int[arr.Length]; // output array  
            int i;
            int[] count = new int[arr.Max()];

            //initializing all elements of count to 0 
            for (i = 0; i < count.Length; i++)
                count[i] = 0;

            // Store count of occurrences in count[]  
            for (i = 0; i < arr.Length; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains actual  
            //  position of this digit in output[]  
            for (i = 1; i < count.Length; i++)
                count[i] += count[i - 1];

            // Build the output array  
            for (i = (arr.Length) - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now  
            // contains sorted numbers according to current digit  
            for (i = 0; i < arr.Length; i++)
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

            Thread.Sleep(60000);
        }
    }
}

