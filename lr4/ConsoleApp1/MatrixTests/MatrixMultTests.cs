using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixMultTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void numberAColumnsNotEqualNumberBRows_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(1, 1);
            Matrix B = new Matrix(2, 1);

            //act
            Matrix C = A * B;
        }

        [TestMethod]
        public void returnMultMatrix()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 1; A[1, 0] = 2; A[0, 1] = 3; A[1, 1] = 4;

            Matrix B = new Matrix(2, 2);
            B[0, 0] = 1; B[1, 0] = 2; B[0, 1] = 3; B[1, 1] = 4;

            Matrix expected = new Matrix(2, 2);
            expected[0, 0] = 7; expected[1, 0] = 10; expected[0, 1] = 15; expected[1, 1] = 22;

            //act
            Matrix C = A * B;

            // assert
            Assert.IsTrue(C == expected);
        }
    }
}
