using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _056_MergeIntervals
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            var comparer = new IntervalComparer();
            var list = intervals.ToList();
            list.Sort(comparer);

            var result = new List<Interval>();
            Interval lastInterval;
            foreach (var interval in list)
            {
                lastInterval = result.LastOrDefault();
                if (lastInterval != null && lastInterval.end >= interval.start)
                {

                    if (lastInterval.end < interval.end)
                        lastInterval.end = interval.end;
                }
                else
                {
                    result.Add(interval);
                }
            }

            return result;
        }

        public class IntervalComparer : IComparer<Interval>
        {
            public int Compare(Interval x, Interval y)
            {
                if (x.start == y.start) return x.end - y.end;
                else return x.start - y.start;
            }
        }

        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }
    }
}
