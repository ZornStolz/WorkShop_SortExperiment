using System;
using SortAlgorithms;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortAlgorithmsTest
{
    [TestClass]
    public class MainTestClass
    {

        private static int size_1 = (Int32)Math.Pow(10, 1);
        private static int size_2 = (Int32) Math.Pow(10,3);
        private static int size_3 = (Int32)Math.Pow(10, 5);

        private int[] ascendentOrder, descendentOrder, randomized;
        private Random random = new Random();

        private void setUp_1()
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

        private void setUp_2()
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

        private void setUp_3()
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

        /**
         * This will 
         */
        [TestMethod]
        public void TestCountSort_1_1()
        {
            setUp_1();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(ascendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 1.1 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], sorted[0]);
            Assert.AreEqual(ascendentOrder[3], sorted[3]);
            Assert.AreEqual(ascendentOrder[5], sorted[5]);
            Assert.AreEqual(ascendentOrder[8], sorted[8]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_1_2()
        {
            setUp_1();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(descendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 1.2 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], sorted[0]);
            Assert.AreEqual(ascendentOrder[3], sorted[3]);
            Assert.AreEqual(ascendentOrder[5], sorted[5]);
            Assert.AreEqual(ascendentOrder[8], sorted[8]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_1_3()
        {
            setUp_1();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(randomized);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 1.3 was {0} ticks", sw.ElapsedTicks);
            bool test = true;

            for (int i = 1; i < size_1; i++)
            {
                if (sorted[(i-1)] > sorted[i])
                    test = false;
            }

            Assert.IsTrue(test);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_2_1()
        {
            setUp_2();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(ascendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 2.1 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], sorted[0]);
            Assert.AreEqual(ascendentOrder[300], sorted[300]);
            Assert.AreEqual(ascendentOrder[500], sorted[500]);
            Assert.AreEqual(ascendentOrder[800], sorted[800]);

        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_2_2()
        {
            setUp_2();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(descendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 2.2 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], sorted[0]);
            Assert.AreEqual(ascendentOrder[300], sorted[300]);
            Assert.AreEqual(ascendentOrder[500], sorted[500]);
            Assert.AreEqual(ascendentOrder[800], sorted[800]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_2_3()
        {
            setUp_2();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(descendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 2.3 was {0} ticks", sw.ElapsedTicks);
            bool test = true;

            for (int i = 1; i < size_2; i++)
            {
                if (sorted[i - 1] > sorted[i])
                    test = false;
            }

            Assert.IsTrue(test);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_3_1()
        {

            setUp_3();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(ascendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 3.1 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], sorted[0]);
            Assert.AreEqual(ascendentOrder[3000], sorted[3000]);
            Assert.AreEqual(ascendentOrder[5000], sorted[5000]);
            Assert.AreEqual(ascendentOrder[8000], sorted[8000]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_3_2()
        {
            setUp_3();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(descendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 3.2 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], sorted[0]);
            Assert.AreEqual(ascendentOrder[3000], sorted[3000]);
            Assert.AreEqual(ascendentOrder[5000], sorted[5000]);
            Assert.AreEqual(ascendentOrder[8000], sorted[8000]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_3_3()
        {
            setUp_3();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] sorted = Algorithms.countSort(randomized);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Count Sort 3.3 was {0} ticks", sw.ElapsedTicks);
            bool test = true;

            for (int i = 1; i < size_3; i++)
            {
                if (sorted[i - 1] > sorted[i])
                    test = false;
            }

            Assert.IsTrue(test);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_1_1()
        {
            setUp_1();
            int[] backup = ascendentOrder;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(ascendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 1.1 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(backup[0], ascendentOrder[0]);
            Assert.AreEqual(backup[3], ascendentOrder[3]);
            Assert.AreEqual(backup[5], ascendentOrder[5]);
            Assert.AreEqual(backup[8], ascendentOrder[8]);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_1_2()
        {
            setUp_1();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(descendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 1.2 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], descendentOrder[0]);
            Assert.AreEqual(ascendentOrder[3], descendentOrder[3]);
            Assert.AreEqual(ascendentOrder[5], descendentOrder[5]);
            Assert.AreEqual(ascendentOrder[8], descendentOrder[8]);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_1_3()
        {
            setUp_1();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(randomized);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 1.3 was {0} ticks", sw.ElapsedTicks);

            bool test = true;

            for (int i = 1; i < size_1; i++)
            {
                if (randomized[i - 1] > randomized[i])
                    test = false;
            }

            Assert.IsTrue(test);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_2_1()
        {
            setUp_2();
            int[] backup = ascendentOrder;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(ascendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 2.1 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(backup[0], ascendentOrder[0]);
            Assert.AreEqual(backup[300], ascendentOrder[300]);
            Assert.AreEqual(backup[500], ascendentOrder[500]);
            Assert.AreEqual(backup[800], ascendentOrder[800]);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_2_2()
        {
            setUp_2();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(descendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 2.2 was {0} ticks", sw.ElapsedTicks);
            Assert.AreEqual(ascendentOrder[0], descendentOrder[0]);
            Assert.AreEqual(ascendentOrder[300], descendentOrder[300]);
            Assert.AreEqual(ascendentOrder[500], descendentOrder[500]);
            Assert.AreEqual(ascendentOrder[800], descendentOrder[800]);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_2_3()
        {
            setUp_2();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(randomized);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 2.3 was {0} ticks", sw.ElapsedTicks);

            bool test = true;

            for (int i = 1; i < size_2; i++)
            {
                if (randomized[i - 1] > randomized[i])
                    test = false;
            }

            Assert.IsTrue(test);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_3_1()
        {
            setUp_3();
            int[] backup = ascendentOrder;
           
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(ascendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 3.1 was {0} ticks", sw.ElapsedTicks);


            Assert.AreEqual(backup[0], ascendentOrder[0]);
            Assert.AreEqual(backup[30000], ascendentOrder[30000]);
            Assert.AreEqual(backup[50000], ascendentOrder[50000]);
            Assert.AreEqual(backup[80000], ascendentOrder[80000]);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_3_2()
        {
            setUp_3();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(descendentOrder);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 3.2 was {0} ticks", sw.ElapsedTicks);

            Assert.AreEqual(ascendentOrder[0], descendentOrder[0]);
            Assert.AreEqual(ascendentOrder[300], descendentOrder[300]);
            Assert.AreEqual(ascendentOrder[500], descendentOrder[500]);
            Assert.AreEqual(ascendentOrder[800], descendentOrder[800]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestRadixSort_3_3()
        {
            setUp_3();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithms.radixsort(randomized);
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("Elapsed Time in Radix Sort 3.3 was {0} ticks", sw.ElapsedTicks);


            bool test = true;

            for (int i = 1; i < size_3; i++)
            {
                if (randomized[i - 1] > randomized[i])
                    test = false;
            }

            Assert.IsTrue(test);
        }
    }
}