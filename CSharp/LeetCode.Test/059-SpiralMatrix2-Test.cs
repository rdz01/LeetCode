using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _059_SpiralMatrix2_Test
    {
        [TestMethod]
        public void GenerateMatrix_1()
        {
            var solution = new _059_SpiralMatrix2();
            var result = solution.GenerateMatrix(1);

            AssertMatrix(new int[,]
            {
                { 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateMatrix_2()
        {
            var solution = new _059_SpiralMatrix2();
            var result = solution.GenerateMatrix(2);

            AssertMatrix(new int[,]
            {
                { 1, 2 },
                { 4, 3 }
            }, result);
        }

        [TestMethod]
        public void GenerateMatrix_3()
        {
            var solution = new _059_SpiralMatrix2();
            var result = solution.GenerateMatrix(3);

            AssertMatrix(new int[,]
            {
                { 1, 2, 3 },
                { 8, 9, 4 },
                { 7, 6, 5 }
            }, result);
        }

        [TestMethod]
        public void GenerateMatrix_4()
        {
            var solution = new _059_SpiralMatrix2();
            var result = solution.GenerateMatrix(4);

            AssertMatrix(new int[,]
            {
                { 1, 2, 3, 4 },
                { 12, 13, 14, 5 },
                { 11, 16, 15, 6 },
                { 10, 9, 8, 7 }
            }, result);
        }

        void AssertMatrix(int[,] expected, int[,] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected.GetLength(0), actual.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), actual.GetLength(1));

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}
