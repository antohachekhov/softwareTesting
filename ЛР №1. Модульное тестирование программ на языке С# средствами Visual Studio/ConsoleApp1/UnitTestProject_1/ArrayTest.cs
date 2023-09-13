using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Program1;

namespace UnitTestProject_1
{
    [TestClass]
    public class ArrayTest
    {

        [TestMethod]
        public void calcMultElemsByInd_Test_C0()
        {
            // Исходные массивы.
            double[] v = new double[] { 1 };
            int[] ind = new int[] { 0 };

            int expected = 1; // Ожидаемое значение.

            var result = ArrayClass.calcMultElemsByInd(v, ind);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void findMinElemWithIndex_Test_C0()
        {
            // Исходные массивы.
            int[] x = new int[] { 0, 1 };

            int[] expected = new int[] { 0, 0 }; // Ожидаемое значение.

            var result = ArrayClass.findMinElemWithIndex(x);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void reverseArray_Test_C0()
        {
            double[] result = new double[] { 1.0, 2.0 };//Исходный массив.
            double[] expected = new double[] { 2.0, 1.0 };//Ожидаемое значение.

            ArrayClass.reverseArray(ref result);

            CollectionAssert.AreEqual(expected, result);//Оракул.
        }
    }
}
