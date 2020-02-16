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
        public void TestBucketSort_()
        {



        }


        /**
         * This will 
         */
        [TestMethod]
        public void TestBucketSort_1()
        {
            setUp_1();

            Assert.AreEqual(ascendentOrder, Algorithms.countSort(ascendentOrder));
            Assert.AreEqual(ascendentOrder, Algorithms.countSort(descendentOrder));
            

            
        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestBucketSort_2()
        {
            setUp_2();


        }

        /**
       * This will 
       */
        [TestMethod]
        public void TestBucketSort_3()
        {
            setUp_3();


        }
    }
}
