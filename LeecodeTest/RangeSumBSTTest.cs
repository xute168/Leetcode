using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class RangeSumBSTTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            var i = new int[] { 10, 5, 15, 3, 7, 18 };
            BinarySeachTree<int> root = new BinarySeachTree<int>();
            foreach (int j in i)
            {
                root.Add(j);
            }
            int L = 3;
            int R = 7;
            int expected = 15;
            //Act
            int actual = a.RangeSumBST(root._root, L, R);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            var i = new int[] { 10, 5, 15, 3, 7, 18 };
            BinarySeachTree<int> root = new BinarySeachTree<int>();
            foreach (int j in i)
            {
                root.Add(j);
            }
            int L = 1;
            int R = 8;
            int expected = 15;
            //Act
            int actual = a.RangeSumBST(root._root, L, R);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            var i = new int[] { 10, 5, 15, 3, 7, 18 };
            BinarySeachTree<int> root = new BinarySeachTree<int>();
            foreach (int j in i)
            {
                root.Add(j);
            }
            int L = 7;
            int R = 15;
            int expected = 32;
            //Act
            int actual = a.RangeSumBST(root._root, L, R);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution a = new Solution();
            var i = new int[] { 10, 5, 15, 3, 7, 13, 18, 1, 6 };
            BinarySeachTree<int> root = new BinarySeachTree<int>();
            foreach (int j in i)
            {
                root.Add(j);
            }
            int L = 6;
            int R = 10;
            int expected = 23;
            //Act
            int actual = a.RangeSumBST(root._root, L, R);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Solution a = new Solution();
            var i = new int[] {18, 9, 27, 6, 15, 24, 30, 3, 12, 21};
            BinarySeachTree<int> root = new BinarySeachTree<int>();
            foreach (int j in i)
            {
                root.Add(j);
            }
            int L = 18;
            int R = 24;
            int expected = 63;
            //Act
            int actual = a.RangeSumBST(root._root, L, R);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }


    }
}
