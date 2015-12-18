using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _075_SortColors_Test
    {
        [TestMethod]
        public void SortColorsTest()
        {
            var input = new int[] { 1, 2, 0, 1, 2, 0, 1, 2, 0 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, input);
        }

        [TestMethod]
        public void SortColorsTest_2()
        {
            var input = new int[] { 0, 1, 0 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 0, 0, 1 }, input);
        }

        [TestMethod]
        public void SortColorsTest_OnlyOneItem_Zero()
        {
            var input = new int[] { 0 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 0 }, input);
        }

        [TestMethod]
        public void SortColorsTest_OnlyOneItem_One()
        {
            var input = new int[] { 1 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 1 }, input);
        }

        [TestMethod]
        public void SortColorsTest_OnlyOneItem_Two()
        {
            var input = new int[] { 2 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 2 }, input);
        }

        [TestMethod]
        public void SortColorsTest_AllSame_Zero()
        {
            var input = new int[] { 0, 0, 0 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 0, 0, 0 }, input);
        }

        [TestMethod]
        public void SortColorsTest_AllSame_One()
        {
            var input = new int[] { 1, 1, 1 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 1, 1, 1 }, input);
        }

        [TestMethod]
        public void SortColorsTest_AllSame_Two()
        {
            var input = new int[] { 2, 2, 2 };

            var solution = new _075_SortColors();
            solution.SortColors(input);

            AssertArray(new int[] { 2, 2, 2 }, input);
        }

        [TestMethod]
        public void SortColors_2Test()
        {
            var input = new int[] { 1, 2, 0, 1, 2, 0, 1, 2, 0 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, input);
        }

        [TestMethod]
        public void SortColors_2Test_2()
        {
            var input = new int[] { 0, 1, 0 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 0, 0, 1 }, input);
        }

        [TestMethod]
        public void SortColors_2Test_OnlyOneItem_Zero()
        {
            var input = new int[] { 0 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 0 }, input);
        }

        [TestMethod]
        public void SortColors_2Test_OnlyOneItem_One()
        {
            var input = new int[] { 1 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 1 }, input);
        }

        [TestMethod]
        public void SortColors_2Test_OnlyOneItem_Two()
        {
            var input = new int[] { 2 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 2 }, input);
        }

        [TestMethod]
        public void SortColors_2Test_AllSame_Zero()
        {
            var input = new int[] { 0, 0, 0 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 0, 0, 0 }, input);
        }

        [TestMethod]
        public void SortColors_2Test_AllSame_One()
        {
            var input = new int[] { 1, 1, 1 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 1, 1, 1 }, input);
        }

        [TestMethod]
        public void SortColors_2Test_AllSame_Two()
        {
            var input = new int[] { 2, 2, 2 };

            var solution = new _075_SortColors();
            solution.SortColors_2(input);

            AssertArray(new int[] { 2, 2, 2 }, input);
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
