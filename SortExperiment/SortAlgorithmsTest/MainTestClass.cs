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
            Assert.AreEqual(ascendentOrder, Algorithms.countSort(ascendentOrder));
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_1_2()
        {
            setUp_1();
            Assert.AreEqual(ascendentOrder, Algorithms.countSort(descendentOrder));
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_1_3()
        {
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
            Assert.AreEqual(ascendentOrder, Algorithms.countSort(ascendentOrder));
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_2_2()
        {
            setUp_2();
            Assert.AreEqual(ascendentOrder, Algorithms.countSort(descendentOrder));
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
            Assert.AreEqual(ascendentOrder, Algorithms.countSort(ascendentOrder));
        }

        /**
        * This will 
        */
        [TestMethod]
        public void TestCountSort_3_2()
        {
            setUp_3();
            Assert.AreEqual(ascendentOrder, Algorithms.countSort(descendentOrder));
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
            Assert.AreEqual(backup, ascendentOrder);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_1_2()
        {
            setUp_1();
            Algorithms.radixsort(descendentOrder);
            Assert.AreEqual(ascendentOrder, descendentOrder);
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
            Assert.AreEqual(backup, ascendentOrder);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_2_2()
        {
            setUp_2();
            Algorithms.radixsort(descendentOrder);
            Assert.AreEqual(ascendentOrder, descendentOrder);
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
            Assert.AreEqual(backup, ascendentOrder);
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestRadixSort_3_2()
        {
            setUp_3();
            Algorithms.radixsort(descendentOrder);
            Assert.AreEqual(ascendentOrder, descendentOrder);
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