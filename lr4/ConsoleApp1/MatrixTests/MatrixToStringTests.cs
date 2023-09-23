
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixToStringTests
    {
        [TestMethod]
        public void returnMatrixInStringFormat()
        {
            //arrange
            Matrix A = new Matrix(2, 2);
            A[0, 0] = 1; A[1, 0] = 2; A[0, 1] = 3; A[1, 1] = 4;

            string expected = "{{1,3},{2,4}}";
            //act
            string result = A.ToString();

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}
