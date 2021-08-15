using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E5_cs
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void ConstructorTests()
        {
            Matrix matrix = new Matrix(2,2);
            matrix[0,0] = 1; matrix[0, 1] = -1;
            matrix[1,0] = 0; matrix[1, 1] = 3;
        Assert.AreEqual(matrix.ColCount,2);
        Assert.AreEqual(matrix.RowCount,2);
        //int[] t={1,-1};
        Assert.AreEqual(matrix[0][0],1);
        }

        [TestMethod]
        public void AddOperatorTest()
        {  Matrix m1 = new Matrix(rows:2,cols:2);
             m1[0,0] = 1; m1[0, 1] = 2;
            m1[1,0] = 0; m1[1, 1] = 1;

            Matrix m2 = new Matrix(2,2);
            m2[0,0] = 1; m2[0, 1] = -1;
            m2[1,0] = 0; m2[1, 1] = 3;
            Matrix result =m1+m2;
            Assert.AreEqual(result[0][0],2);
            Assert.AreEqual(result[1][0],0);
            Assert.AreEqual(result[0][1],1);
            Assert.AreEqual(result[1][1],4);
                   }

        [TestMethod]
        public void SingleIndexerTest()
        {Matrix m2 = new Matrix(rows:2,cols:2);
            m2[0] = new int[2] {1, 2};
            m2[1] = new int[2] {0, 1};
            Assert.AreEqual(m2[0,0],1);
            Assert.AreEqual(m2[1,1],1);
        }

        [TestMethod]
        public void DoubleIndexerTest()
        {   Matrix m1 = new Matrix(rows:2,cols:2);
            m1[0,0] = 1; m1[0, 1] = 2;
            m1[1,0] = 0; m1[1, 1] = 1;
            
            Assert.AreEqual(m1[0,0],1);
           
        }

        [TestMethod]
        [ExpectedException(typeof(DimensionMisMatchException))]
        public void AddOperatorExceptionTest()
        { Matrix m2 = new Matrix(2,2);
            m2[0,0] = 1; m2[0, 1] = -1;
            m2[1,0] = 0; m2[1, 1] = 3;
            Matrix m1 = new Matrix(rows:1,cols:2);
            m1[0] = new int[2] {1, 2};
            Matrix sum = m1 + m2;
           // Assert.AreEqual("DimensionMisMatchException",);
        }




    }
}
