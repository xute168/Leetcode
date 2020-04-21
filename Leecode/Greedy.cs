using System;
using System.Collections.Generic;

using System.Text;

namespace Leecode
{
    public class Greedy
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, new Comparison<int[]>((x,
                y) => { return x[1] - x[0] < y[1] - y[0] ? -1 : (x[1] - x[0] > y[1] - y[0] ? 1 : 0); }));

            return 1;
        }
    }
}
