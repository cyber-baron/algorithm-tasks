using System;
using System.Collections.Generic;
using System.Linq;

namespace Merge_Intervals
{
    class Solution
    {
        static void Main(string[] args)
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
                                             
            var result = SortAndMerge(intervals);
            foreach(var res in result)
            {
                Console.WriteLine("[" + res[0] + " , " + res[1] + "]");
            }
        }

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
