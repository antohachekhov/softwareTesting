using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixSumTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void numberRowsNotEqual_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(1, 1);
            Matrix B = new Matrix(2, 1);

            //act
            Matrix C = A + B;
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void numberColumnsNotEqual_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(1, 2);
            Matrix B = new Matrix(1, 1);

            //act
            Matrix C = A + B;
        }


        [TestMethod]
        public void returnSumMatrix()
        {
            //arrange
            // Заполнение единицами
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 1; A[1, 0] = 1; A[0, 1] = 1; A[1, 1] = 1;

            // Заполнение двойками
            Matrix B = new Matrix(2, 2);
            B[0, 0] = 2; B[1, 0] = 2; B[0, 1] = 2; B[1, 1] = 2;

            Matrix expected = new Matrix(2, 2);
            expected[0,0] = 3; expected[1,0] = 3; expected[0,1] = 3; expected[1,1] = 3;

            //act
            Matrix C = A + B;

            // assert
            Assert.IsTrue(C == expected);
        }
    }
}
