using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class OddCellsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            int[][] nums = new int[][] { new int[] { 3, 2 }, new int[] { -2, 2 } };
            int expected = 6; 

            //Act
            var actual = a.OddCells(2,3, nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrage
            Solution a = new Solution();
            int[][] nums = new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 } };
            int expected = 0;

            //Act
            var actual = a.OddCells(2, 2, nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrage
            Solution a = new Solution();
            int[][] nums = new int[][] { new int[] { 40, 5 } };
            int expected = 83;

            //Act
            var actual = a.OddCells(48, 37, nums);
            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
