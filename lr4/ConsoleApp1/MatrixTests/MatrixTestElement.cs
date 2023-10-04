
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTestElement
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Get_IOutOfBoundsIsLessZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = -1;
            //act
            int el = A[i, 0];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Get_JOutOfBoundsIsLessZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = -1;
            //act
            int el = A[0, j];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Get_IOutOfBoundsIsEqualLength_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = 2;
            //act
            int el = A[i, 0];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Get_JOutOfBoundsIsEqualZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = -1;
            //act
            int el = A[0, j];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Set_IOutOfBoundsIsLessZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = -1;
            //act
            A[i, 0] = 10;
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Set_JOutOfBoundsIsLessZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = -1;
            //act
            A[0, j] = 10;
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Set_IOutOfBoundsIsEqualLength_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = 2;
            //act
            A[i, 0] = 10;
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Set_JOutOfBoundsIsEqualZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = -1;
            //act
            A[0, j] = 10;
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Get_IOutOfBoundsIsHightLength_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = 3;
            //act
            int el = A[i, 0];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Get_JOutOfBoundsIsHightZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = 3;
            //act
            int el = A[0, j];
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Set_IOutOfBoundsIsHightLength_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int i = 3;
            //act
            A[i, 0] = 10;
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void Set_JOutOfBoundsIsHightZero_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            int j = 3;
            //act
            A[0, j] = 10;
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
