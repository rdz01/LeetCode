using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    public static class AssertHelper
    {
        public static void AssertLinkList(int[] expected, ListNode actual)
        {
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            Assert.IsTrue(expected.Length > 0);

            var current = actual;
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsNotNull(current);
                Assert.AreEqual(expected[i], current.val);
                current = current.next;
            }

            Assert.IsNull(current);
        }

        public static void AssertArray<T>(T[] expected, T[] actual, bool ignoreLength = false)
        {
            if (!ignoreLength)
            {
                Assert.AreEqual(expected.Length, actual.Length);
            }

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public static void AssertArray<T>(T[,] expected, T[,] actual)
        {
            var temp = expected.GetLength(1);

            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }

        public static void AssertList<T>(T[] expected, IList<T> actual)
        {
            Assert.AreEqual(expected.Length, actual.Count);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        public static void AssertList<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count);
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        public static void AssertMatrix(int[,] expected, int[,] actual)
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
