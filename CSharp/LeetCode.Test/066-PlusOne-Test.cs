using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _066_PlusOne_Test
    {
        [TestMethod]
        public void PlusOneTest()
        {
            var input = new int[] { 1, 2, 3 };

            var solution = new _066_PlusOne();
            var result = solution.PlusOne(input);

            AssertArray(new int[] { 1, 2, 4 }, result);
        }

        [TestMethod]
        public void PlusOneTest_Zero()
        {
            var input = new int[] { 0 };

            var solution = new _066_PlusOne();
            var result = solution.PlusOne(input);

            AssertArray(new int[] { 1 }, result);
        }

        [TestMethod]
        public void PlusOneTest_WithCarry()
        {
            var input = new int[] { 9, 9, 9 };

            var solution = new _066_PlusOne();
            var result = solution.PlusOne(input);

            AssertArray(new int[] { 1, 0, 0, 0 }, result);
        }


        void AssertArray(int[] expected, int[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
