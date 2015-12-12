using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _068_TextJustification_Test
    {
        [TestMethod]
        public void FullJustifyTest()
        {
            var input = new string[] { "This", "is", "an", "example", "of", "text", "justification." };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 16);

            AssertStrings(new string[] {
                "This    is    an",
                "example  of text",
                "justification.  "
            }, result);
        }

        [TestMethod]
        public void FullJustifyTest_OneLine()
        {
            var input = new string[] { "justification." };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 16);

            AssertStrings(new string[] {
                "justification.  "
            }, result);
        }

        [TestMethod]
        public void FullJustifyTest_JustEnough()
        {
            var input = new string[] { "This", "is", "an", "example", "of", "text" };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 7);

            AssertStrings(new string[] {
                "This is",
                "an     ",
                "example",
                "of text"
            }, result);
        }

        [TestMethod]
        public void FullJustifyTest_AlittleLess()
        {
            var input = new string[] { "This", "is", "an", "of", "text" };

            var solution = new _068_TextJustification();
            var result = solution.FullJustify(input, 6);

            AssertStrings(new string[] {
                "This  ",
                "is  an",
                "of    ",
                "text  "
            }, result);
        }


        void AssertStrings(IList<string> expected, IList<string> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
