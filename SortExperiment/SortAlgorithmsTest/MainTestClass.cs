using System;
using SortAlgorithms;
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
            Assert.AreEqual(ascendentOrder[0], Algorithms.countSort(ascendentOrder)[0]);
            Assert.AreEqual(ascendentOrder[3], Algorithms.countSort(ascendentOrder)[3]);
            Assert.AreEqual(ascendentOrder[5], Algorithms.countSort(ascendentOrder)[5]);
            Assert.AreEqual(ascendentOrder[8], Algorithms.countSort(ascendentOrder)[8]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_1_2()
        {
            setUp_1();
            Assert.AreEqual(ascendentOrder[0], Algorithms.countSort(descendentOrder)[0]);
            Assert.AreEqual(ascendentOrder[3], Algorithms.countSort(descendentOrder)[3]);
            Assert.AreEqual(ascendentOrder[5], Algorithms.countSort(descendentOrder)[5]);
            Assert.AreEqual(ascendentOrder[8], Algorithms.countSort(descendentOrder)[8]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_1_3()
        {
            setUp_1();
            Algorithms.countSort(randomized);

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
        public void TestCountSort_2_1()
        {
            setUp_2();
            Assert.AreEqual(ascendentOrder[0], Algorithms.countSort(ascendentOrder)[0]);
            Assert.AreEqual(ascendentOrder[300], Algorithms.countSort(ascendentOrder)[300]);
            Assert.AreEqual(ascendentOrder[500], Algorithms.countSort(ascendentOrder)[500]);
            Assert.AreEqual(ascendentOrder[800], Algorithms.countSort(ascendentOrder)[800]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_2_2()
        {
            setUp_2();
            Assert.AreEqual(ascendentOrder[0], Algorithms.countSort(ascendentOrder)[0]);
            Assert.AreEqual(ascendentOrder[300], Algorithms.countSort(ascendentOrder)[300]);
            Assert.AreEqual(ascendentOrder[500], Algorithms.countSort(ascendentOrder)[500]);
            Assert.AreEqual(ascendentOrder[800], Algorithms.countSort(ascendentOrder)[800]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_2_3()
        {
            setUp_2();
            Algorithms.countSort(randomized);

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
        public void TestCountSort_3_1()
        {
            setUp_3();
            Assert.AreEqual(ascendentOrder[0], Algorithms.countSort(ascendentOrder)[0]);
            Assert.AreEqual(ascendentOrder[30000], Algorithms.countSort(ascendentOrder)[30000]);
            Assert.AreEqual(ascendentOrder[50000], Algorithms.countSort(ascendentOrder)[50000]);
            Assert.AreEqual(ascendentOrder[80000], Algorithms.countSort(ascendentOrder)[80000]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_3_2()
        {
            setUp_3();
            Assert.AreEqual(ascendentOrder[0], Algorithms.countSort(ascendentOrder)[0]);
            Assert.AreEqual(ascendentOrder[30000], Algorithms.countSort(ascendentOrder)[30000]);
            Assert.AreEqual(ascendentOrder[50000], Algorithms.countSort(ascendentOrder)[50000]);
            Assert.AreEqual(ascendentOrder[80000], Algorithms.countSort(ascendentOrder)[80000]);
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_3_3()
        {
            setUp_3();
            Algorithms.countSort(randomized);

            bool test = true;

            for (int i = 1; i < size_3; i++)
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
        public void TestRadixSort_1_1()
        {
            setUp_1();
            int[] backup = ascendentOrder;
            Algorithms.radixsort(ascendentOrder);
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
            Algorithms.radixsort(descendentOrder);
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
            Algorithms.radixsort(randomized);

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
            Algorithms.radixsort(ascendentOrder);
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
            Algorithms.radixsort(descendentOrder);
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
            Algorithms.radixsort(randomized);

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
            Algorithms.radixsort(ascendentOrder);
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
            Algorithms.radixsort(descendentOrder);
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
            Algorithms.radixsort(randomized);

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