using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using SortAlgorithms;

namespace Code
{
    class Program
    {

        private static int size_1 = (Int32)Math.Pow(10, 1);
        private static int size_2 = (Int32)Math.Pow(10, 3);
        private static int size_3 = (Int32)Math.Pow(10, 5);

        private static int[] ascendentOrder, descendentOrder, randomized;
        private static Random random = new Random();

        private static void setUp_1()
        {

            ascendentOrder = new int[size_1];
            descendentOrder = new int[size_1];
            randomized = new int[size_1];

            for (int i = 0; i < size_1; i++)
            {
                ascendentOrder[i] = i + 1;
            }

            int k = 0;

            for (int i = size_1; i > 0; i--)
            {
                descendentOrder[k] = i;
                k++;
            }

            for (int i = 0; i < size_1; i++)
            {
                randomized[i] = random.Next(1, size_1 + 1);
            }

        }

        private static void setUp_2()
        {

            ascendentOrder = new int[size_2];
            descendentOrder = new int[size_2];
            randomized = new int[size_2];

            for (int i = 0; i < size_2; i++)
            {
                ascendentOrder[i] = i + 1;
            }

            int k = 0;

            for (int i = size_2; i > 0; i--)
            {
                descendentOrder[k] = i;
                k++;
            }

            for (int i = 0; i < size_2; i++)
            {
                randomized[i] = random.Next(1, size_2 + 1);
            }

        }

        private static void setUp_3()
        {

            ascendentOrder = new int[size_3];
            descendentOrder = new int[size_3];
            randomized = new int[size_3];

            for (int i = 0; i < size_3; i++)
            {
                ascendentOrder[i] = i + 1;
            }

            int k = 0;

            for (int i = size_3; i > 0; i--)
            {
                descendentOrder[k] = i;
                k++;
            }

            for (int i = 0; i < size_3; i++)
            {
                randomized[i] = random.Next(1, size_3 + 1);
            }

        }

        public static void Main()
        {

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
             * Counting Sort
             */

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine("Counting sort");
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine();

            int times = 35;

            /*
             * Ascendent  set up 1
             */

            Console.WriteLine("Ascendent, " + times + " times. Time in ticks. Set Up 1");

            while (times > -1)
            {
                setUp_1();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(ascendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Descendent set up 1
             */

            Console.WriteLine("Descendent, " + times + " times. Time in ticks. Set Up 1");

            while (times > -1)
            {
                setUp_1();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(descendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Random set up 1
             */

            Console.WriteLine("Random, " + times + " times. Time in ticks. Set Up 1");

            while (times > -1)
            {
                setUp_1();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(randomized);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Ascendent set up 2
             */

            Console.WriteLine("Ascendent, " + times + " times. Time in ticks. Set Up 2");

            while (times > -1)
            {
                setUp_2();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(ascendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Descendent set up 2
             */

            Console.WriteLine("Descendent, " + times + " times. Time in ticks. Set Up 2");

            while (times > -1)
            {
                setUp_2();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(descendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Random set up 2
             */

            Console.WriteLine("Random, " + times + " times. Time in ticks. Set Up 2");

            while (times > -1)
            {
                setUp_2();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(randomized);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Ascendent set up 3
             */

            Console.WriteLine("Ascendent, " + times + " times. Time in ticks. Set Up 3");

            while (times > -1)
            {
                setUp_3();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(ascendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Descendent set up 3
             */

            Console.WriteLine("Descendent, " + times + " times. Time in ticks. Set Up 3");

            while (times > -1)
            {
                setUp_3();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(descendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Random set up 3
             */

            Console.WriteLine("Random, " + times + " times. Time in ticks. Set Up 3");

            while (times > -1)
            {
                setUp_3();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                int[] sorted = Algorithms.countSort(randomized);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
             * Radix Sort
             */

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine("Radix sort");
            Console.WriteLine("////////////////////////////////////////////");
            Console.WriteLine();

            times = 35;

            /*
             * Ascendent  set up 1
             */

            Console.WriteLine("Ascendent, " + times + " times. Time in ticks. Set Up 1");

            while (times > -1)
            {
                setUp_1();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                Algorithms.radixsort(ascendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Descendent set up 1
             */

            Console.WriteLine("Descendent, " + times + " times. Time in ticks. Set Up 1");

            while (times > -1)
            {
                setUp_1();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                Algorithms.radixsort(descendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Random set up 1
             */

            Console.WriteLine("Random, " + times + " times. Time in ticks. Set Up 1");

            while (times > -1)
            {
                setUp_1();

                Stopwatch sw = new Stopwatch();
                
                try
                {
                    sw.Start();
                    Algorithms.radixsort(randomized);
                    sw.Stop();
                }
                catch (Exception e){ }

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Ascendent set up 2
             */

            Console.WriteLine("Ascendent, " + times + " times. Time in ticks. Set Up 2");

            while (times > -1)
            {
                setUp_2();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                Algorithms.radixsort(ascendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Descendent set up 2
             */

            Console.WriteLine("Descendent, " + times + " times. Time in ticks. Set Up 2");

            while (times > -1)
            {
                setUp_2();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                Algorithms.radixsort(descendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Random set up 2
             */

            Console.WriteLine("Random, " + times + " times. Time in ticks. Set Up 2");

            while (times > -1)
            {
                setUp_2();

                Stopwatch sw = new Stopwatch();
                try
                {
                    sw.Start();
                    Algorithms.radixsort(randomized);
                    sw.Stop();
                }
                catch (Exception e) { }

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Ascendent set up 3
             */

            Console.WriteLine("Ascendent, " + times + " times. Time in ticks. Set Up 3");

            while (times > -1)
            {
                setUp_3();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                Algorithms.radixsort(ascendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Descendent set up 3
             */

            Console.WriteLine("Descendent, " + times + " times. Time in ticks. Set Up 3");

            while (times > -1)
            {
                setUp_3();

                Stopwatch sw = new Stopwatch();
                sw.Start();
                Algorithms.radixsort(descendentOrder);
                sw.Stop();

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            times = 35;

            /*
             * Random set up 3
             */

            Console.WriteLine("Random, " + times + " times. Time in ticks. Set Up 3");

            while (times > -1)
            {
                setUp_3();

                Stopwatch sw = new Stopwatch();
                try
                {
                    sw.Start();
                    Algorithms.radixsort(randomized);
                    sw.Stop();
                }
                catch (Exception e) { }

                Console.WriteLine(sw.ElapsedTicks);

                times--;
            }

            Thread.Sleep(1200000);
        }
    }
}

