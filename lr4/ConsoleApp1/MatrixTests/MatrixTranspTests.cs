using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTranspTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void numberRowsNotEqualNumberColumns_Expected_MyException()
        {
            //arrange
            Matrix A = new Matrix(1, 2);

            //act
            A.Transp();
        }

        [TestMethod]
        public void returnTranspMatrix()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 1; A[1, 0] = 2; A[0, 1] = 3; A[1, 1] = 4;

            Matrix expected = new Matrix(2, 2);
            expected[0, 0] = 1; expected[1, 0] = 3; expected[0, 1] = 2; expected[1, 1] = 4;

            //act
            Matrix result = A.Transp();

            // assert
            CollectionAssert.Equals(expected, result);
        }
    }
}
