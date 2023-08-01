/// <description>
/// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.
/// 
/// Example 1:
/// Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
/// Output: [[1,6],[8,10],[15,18]]
/// 
/// Example 2:
/// Input: intervals = [[1,4],[4,5]]
/// Output: [[1,5]]
/// 
/// Constraints:
/// 1 <= intervals.length <= 104
/// intervals[i].length == 2
/// 0 <= starti <= endi <= 104
/// 
/// </description>
public class MergeInvervalsSolution
{
    public int[][] Merge(int[][] intervals)
    {
        List<int[]> result = new List<int[]>();

        Array.Sort(intervals, (x1, y1) => x1[0] - y1[0]);

        var (x1, x2) = (intervals[0][0], intervals[0][1]);

        foreach (var i in intervals.Skip(1))
        {
            if (i[0].IsWithin(x1, x2))
            {
                x2 = Math.Max(x2, i[1]);
            }
            else
            {
                result.AddInterval(x1, x2);
                (x1,x2) = (i[0], i[1]);
            }
        }

        result.AddInterval(x1, x2);

        return result.ToArray();
    }
}

public static class Extensions
{
    public static void AddInterval(this List<int[]> list, int n1, int n2) => list.Add(new int[] { n1, n2 });
    public static bool IsWithin(this int n, int x1, int x2) => n >= x1 && n <= x2;
}

/// <explanation>
/// To merge overlapping intervals you first need to arrange interval in ascending order of first element. After that just compare first element with the range.
/// </explanation>
