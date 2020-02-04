using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class MinFlips
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution solution = new Solution();
            int a = 2;
            int b = 6;
            int c = 5;
            int expected = 3;

            //Act
            var actual = solution.MinFlips(a,b,c);
            //Assert            
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution solution = new Solution();
            int a = 7;
            int b = 7;
            int c = 7;
            int expected = 0;

            //Act
            var actual = solution.MinFlips(a, b, c);
            //Assert            
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution solution = new Solution();
            int a = 4;
            int b = 2;
            int c = 7;
            int expected = 1;

            //Act
            var actual = solution.MinFlips(a, b, c);
            //Assert            
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrage
            Solution solution = new Solution();
            int a = 1;
            int b = 2;
            int c = 3;
            int expected = 0;

            //Act
            var actual = solution.MinFlips(a, b, c);
            //Assert            
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrage
            Solution solution = new Solution();
            int a = 8;
            int b = 3;
            int c = 5;
            int expected = 3;

            //Act
            var actual = solution.MinFlips(a, b, c);
            //Assert            
            Assert.AreEqual(expected, actual);

        }
    }
}
