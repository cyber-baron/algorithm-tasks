using System;
using System.Collections.Generic;
using System.Linq;

namespace Merge_Intervals
{
    class Solution
    {
        static int[][] SortAndMerge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            
            LinkedList<int[]> mapper = new LinkedList<int[]>();
            foreach(int[] interval in intervals)
            {
                if(mapper.Count == 0 || mapper.Last()[1] < interval[0])
                {
                    mapper.AddLast(interval);
                }

                mapper.Last()[1] = Math.Max(mapper.Last()[1], interval[1]);
            }

            return mapper.ToArray();
        }
    }
}
