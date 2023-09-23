using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixEqualTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void numberRowsNotEqual_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(1, 1);
            Matrix B = new Matrix(2, 1);

            //act
            bool equal = A == B;
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void numberColumnsNotEqual_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(1, 2);
            Matrix B = new Matrix(1, 1);

            //act
            bool equal = A == B;
        }

        [TestMethod]
        public void returnEqualMatrix()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 1; A[1, 0] = 2; A[0, 1] = 3; A[1, 1] = 4;

            Matrix B = new Matrix(2, 2);
            B[0, 0] = 1; B[1, 0] = 2; B[0, 1] = 3; B[1, 1] = 4;

            //act
            bool result = A == B;

            // assert
            Assert.IsTrue(result);
        }
    }
}
