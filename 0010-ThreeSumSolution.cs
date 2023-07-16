/// <description>
/// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
/// Notice that the solution set must not contain duplicate triplets.
/// 
/// Example 1:
/// Input: nums = [-1,0,1,2,-1,-4]
/// Output: [[-1,-1,2],[-1,0,1]]
/// 
/// Example 2:
/// Input: nums = [0,1,1]
/// Output: []
/// 
/// Input: nums = [0,0,0]
/// Output: [[0,0,0]]
/// 
/// Constraints:
/// 3 <= nums.length <= 3000
/// -105 <= nums[i] <= 105
/// 
/// </description>
public class ThreeSumSolution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var list = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int low = i + 1, high = nums.Length - 1;
            while (low < high)
            {
                int sum = nums[i] + nums[low] + nums[high];
                if (sum == 0)
                {
                    list.Add(new List<int>() { nums[i], nums[low], nums[high] });
                    low++;
                    while (low < nums.Length && nums[low] == nums[low - 1]) low++;
                }
                else if (sum > 0)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
        }
        return list;
    }
}

/// <explanation>
/// The Brute force way to get the answer is to find the all triplets of the nums array and then check if triplet is 0. This solution will be done in O(n) complexity.
/// The optimal solution will require array to be sorted which can be done in O(n^2).
/// 
/// After sorted, iterate over the array and try binary approach in rest of the array. This can also done in O(n^2).
/// 
/// So overall complexity of the solution will be O(n^2 + n^2) = O(n^2)
/// </explanation>
