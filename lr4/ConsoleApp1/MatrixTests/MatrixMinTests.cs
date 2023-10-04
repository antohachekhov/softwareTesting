using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixMinTests
    {
        [TestMethod]
        public void returnMinMatrixElement()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 3; A[1, 0] = 2; A[0, 1] = 1; A[1, 1] = 4;

            int expected = 1;
            //act
            int result = A.Min();

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}
