/// <summary>
/// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
/// 
/// Example 1:
/// Input: nums = [1,1,1,2,2,3], k = 2
/// Output: [1,2]
/// 
/// Example 2:
/// Input: nums = [1], k = 1
/// Output: [1]
/// 
/// Constraints:
/// 1 <= nums.length <= 105
/// -104 <= nums[i] <= 104
/// k is in the range[1, the number of unique elements in the array].
/// It is guaranteed that the answer is unique.
/// </summary>
public class TopKFrequentElementsSolution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int,int> pairs = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (!pairs.ContainsKey(i)) pairs[i] = 0;
            pairs[i]++;
        }
        return pairs.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}

/// <explanation>
/// Create a dictionary of frequency. Sort accoring to frequency in descending order and take top 2.
/// </explanation>
