/// <description>
/// Given an array of intervals intervals where intervals[i] = [starti, endi], return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.
/// 
/// Example 1:
/// Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
/// Output: 1
/// 
/// Example 2:
/// Input: intervals = [[1,2],[1,2],[1,2]]
/// Output: 2
/// 
/// Example 3:
/// Input: intervals = [[1,2],[2,3]]
/// Output: 0
/// 
/// Constraints:
/// 1 <= intervals.length <= 105
/// intervals[i].length == 2
/// -5 * 104 <= starti <endi <= 5 * 104
/// </description>
public class NonOverlappingIntervalsSolution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[0] - y[0]);

        int result = 0;
        var interval = intervals[0];

        foreach (var i in intervals.Skip(1))
        {
            if (i.IsOverlapping(interval))
            {
                if (interval[1] > i[1])
                {
                    interval = i;
                }
                result++;
            }
            else
            {
                interval = i;
            }
        }

        return result;
    }
}
public static class MyExtensions
{
    public static bool IsOverlapping(this int[] i1, int[] i2) => i1[0] >= i2[0] && i1[0] < i2[1];
}
/// <explanation>
/// To remove those interval which are overlapping, first we need to find overlapping intervals (check IsOverlapping function). Then we have 2 choice, either remove which is longer interval or remove which end later.
/// By removing interval which end later you're reducing the chance of overalpping.
/// </explanation>
