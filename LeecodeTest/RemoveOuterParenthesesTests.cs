using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecode;

namespace LeecodeTest
{
    [TestClass]
    public class RemoveOuterParenthesesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "(()())(())";
            string expected = "()()()";

            //Act
            var actual = a.RemoveOuterParentheses(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "(()())(())(()(()))";
            string expected = "()()()()(())";

            //Act
            var actual = a.RemoveOuterParentheses(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrage
            Solution a = new Solution();
            string nums = "()()";
            string expected = "";

            //Act
            var actual = a.RemoveOuterParentheses(nums);
            //Assert
            //Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);

        }
        

    }
}
