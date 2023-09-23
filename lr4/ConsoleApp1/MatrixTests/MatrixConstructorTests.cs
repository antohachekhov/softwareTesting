using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace MatrixTests
{
    [TestClass]
    public class MatrixConstructorTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void iLessThen0_Expected_MyException()
        {
            //arrange
            int I = -1;
            int J = 1;

            //act
            new Matrix(I, J);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void JLessThen0_Expected_MyException()
        {
            //arrange
            int I = 1;
            int J = -1;

            //act
            new Matrix(I, J);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void iEqual0_Expected_MyException()
        {
            //arrange
            int I = 0;
            int J = 1;

            //act
            new Matrix(I, J);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void jEqual0_Expected_MyException()
        {
            //arrange
            int I = 1;
            int J = 0;

            //act
            new Matrix(I, J);
        }

        [TestMethod]
        public void returnZeroMatrix()
        {
            //arrange
            int I = 1;
            int J = 1;

            int[,] expected = new int[I, J];

            //act
            Matrix result = new Matrix(I, J);

            //assert
            CollectionAssert.Equals(expected, result);
        }

        [TestMethod]
        public void setNumberRowsAndColumns()
        {
            //arrange
            int I = 1;
            int J = 2;

            int[] expected = { I, J };

            //act
            Matrix result = new Matrix(I, J);

            //assert
            CollectionAssert.Equals(expected, result.Property);
        }
    }
}