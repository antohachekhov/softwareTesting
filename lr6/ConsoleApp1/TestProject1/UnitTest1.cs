using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCyclicShift1()
        {
            int[] arr = { 1, 2, 3 };
            int shift = 1;

            Program.CyclicShift(ref arr, shift);

            int[] actual = { 2, 3, 1 };

            CollectionAssert.AreEqual(arr, actual);
        }

        [TestMethod]
        public void TestCyclicShift2()
        {
            int[] arr = { 1, 2, 3 };
            int shift = 4;

            Program.CyclicShift(ref arr, shift);

            int[] actual = { 2, 3, 1 };

            CollectionAssert.AreEqual(arr, actual);
        }
        [TestMethod]
        public void TestReplace1()
        {
            int[] arr = { 1, 2, 3 };
            int value = 1;
            int value2 = 5;

            Program.Replace(ref arr, value, value2);

            int[] actual = { 5, 2, 3 };

            CollectionAssert.AreEqual(arr, actual);
        }

        [TestMethod]
        public void TestReplace2()
        {
            int[] arr = { 1, 2, 3 };
            int value = 5;
            int value2 = 1;

            Program.Replace(ref arr, value, value2);

            int[] actual = { 1, 2, 3 };

            CollectionAssert.AreEqual(arr, actual);
        }

        [TestMethod]
        public void TestReplace3()
        {
            int[] arr = { 3, 3, 3 };
            int value = 3;
            int value2 = 1;

            Program.Replace(ref arr, value, value2);

            int[] actual = { 1, 1, 1 };

            CollectionAssert.AreEqual(arr, actual);
        }

        [TestMethod]
        public void TestInverse1()
        {
            int[] arr = { 1, 2, 3 };

            Program.Inverse(ref arr);

            int[] actual = { 3, 2, 1 };

            CollectionAssert.AreEqual(arr, actual);
        }

        [TestMethod]
        public void TestBinarySearch1()
        {
            int[] arr = { 1, 2, 3 };
            int val = 2;

            int resultInd = Program.BinarySearch(arr, val);
            int actualInd = 1;
            Assert.AreEqual(resultInd, actualInd);
        }

        [TestMethod]
        public void TestBinarySearch2()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int val = 5;

            int resultInd = Program.BinarySearch(arr, val);
            int actualInd = 4;
            Assert.AreEqual(resultInd, actualInd);
        }


        [TestMethod]
        public void TestMin()
        {
            int[] arr = {  1, 3, 1, 4  };

            (int, int) result = Program.Min(arr);

            (int, int) actual = (1, 2);

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void TestSortBubble()
        {
            int[] arr = { 1, 4, 2, 3 };

            Program.SortBubble(ref arr);

            int[] actual = { 1, 2, 3, 4 };

            CollectionAssert.AreEqual(arr, actual);
        }

        [TestMethod]
        public void TestMin2()
        {
            int[,] arr = { { 3, 5 }, { 2, 8 } };

            (int, int, int) result = Program.Min2(arr);

            (int, int, int) actual = (2, 1, 0);

            Assert.AreEqual(result, actual);
        }

    }
}
