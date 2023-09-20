using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void minElemCAB_Test_C1()
        {
            //arrange
            double a = 1, b = 2, c = 0;
            int expected = 0;

            // act
            var result = Class1.findMin(a, b, c);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void minElemABC_Test_C1()
        {
            //arrange
            double a = 1, b = 2, c = 3;
            int expected = 1; 

            // act
            var result = Class1.findMin(a, b, c);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void minElemCBA_Test_C1()
        {
            //arrange
            double a = 2, b = 1, c = 0;
            int expected = 0;

            // act
            var result = Class1.findMin(a, b, c);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void minElemBAC_Test_C1()
        {
            //arrange
            double a = 2, b = 1, c = 3;
            int expected = 1;

            // act
            var result = Class1.findMin(a, b, c);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void findSumElements_Test_C1()
        {
            //arrange
            double[,] A = { { 1, 2 } };
            int expected = 1; 

            // act
            var result = Class1.findSumElements(A);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void maxElem_Test_C1()
        {
            // arrange
            double[,] A = { { 1, 2 }, { 3, 4}};

            int expected = 4; 

            // act
            var result = Class1.maxElem(A);

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}
