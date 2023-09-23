
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTestElement
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void IOutOfBoundsIsLessZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = -1;
            //act
            int el = A[i, 0];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void JOutOfBoundsIsLessZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = -1;
            //act
            int el = A[0, j];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void IOutOfBoundsIsEqualLength_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = 2;
            //act
            int el = A[i, 0];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void JOutOfBoundsIsEqualZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = -1;
            //act
            int el = A[0, j];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void IOutOfBoundsIsHightLength_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = 3;
            //act
            int el = A[i, 0];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void JOutOfBoundsIsHightZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = 3;
            //act
            int el = A[0, j];
        }

        [TestMethod]
        public void getMatrixElement()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 1; A[1, 0] = 2; A[0, 1] = 3; A[1, 1] = 4;

            int expected = 3;
            //act
            int result = A[0, 1];

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void setMatrixElement()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 1; A[1, 0] = 2; A[0, 1] = 3; A[1, 1] = 4;

            int expected = 10;
            //act
            A[0, 1] = 10;

            // assert
            Assert.AreEqual(expected, A[0, 1]);
        }
    }
}
