using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        
        [TestMethod]
        public void BracketBal_emptyString_isTrue()
        {
            string testCase = ("");
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsTrue(testResult);
        }


        [TestMethod]
        public void BracketBal_OnePairOfBrackets_IsTrue()
        {
            string testCase = "[]";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsTrue(testResult);
        }

        [TestMethod]
        public void BracketBal_SingleOpening_isFalse()
        {
            string testCase = "[";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsFalse(testResult);
        }

        [TestMethod]
        public void BracketBal_SingleClosing_isFalse()
        {
            string testCase = "]";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsFalse(testResult);
        }

        [TestMethod]
        public void BracketBal_BackwardPair_IsFalse()
        {
            string testCase = "][";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsFalse(testResult);
        }


        [TestMethod]
        public void BracketBal_BalancedContainsString_isTrue()
        {
            string testCase = "[LaunchCode]";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsTrue(testResult);
        }

        [TestMethod]
        public void BracketBal_OneOpenBracketContainsString_isFalse()
        {
            string testCase = "[LaunchCode";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsFalse(testResult);
        }

        [TestMethod]
        public void BracketBal_OneClosedBracketContainsString_isFalse()
        {
            string testCase = "LaunchCode]";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsFalse(testResult);
        }

        public void BracketBal_StringSurroundsBalancedBracket_isTrue()
        {
            string testCase = "Launch[Code]";
            bool testResult = BalancedBrackets.HasBalancedBrackets(testCase);
            Assert.IsTrue(testResult);
        }


        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}
    }
}
