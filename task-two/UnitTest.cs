using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Basic_array_with_intervals()
        {
            int[][] intervals = new int[][]
            {
                new int[] { 11, 12 },
                new int[] { 2, 3 },
                new int[] { 5, 7 },
                new int[] { 1, 4 },
                new int[] { 8, 10 },
                new int[] { 6, 8 }
            };

            Solution s = new Solution();
            // act somehow
            
            // Assert.AreEqual()
        }
    }
}
