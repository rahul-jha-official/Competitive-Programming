/// <description>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// 
/// Example 1:
/// Input: nums = [2,7,11,15], target = 9
/// Output: [0,1]
/// 
/// Example 2:
/// Input: nums = [3,2,4], target = 6
/// Output: [1,2]
/// 
/// Example 3:
/// Input: nums = [3,3], target = 6
/// Output: [0,1]
/// 
/// Constraints:
/// 2 <= nums.length <= 10^4
/// -10^9 <= nums[i] <= 10^9
/// -10^9 <= target <= 10^9
/// </description>
public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var pair = new Dictionary<int, int>()
        {
            {nums[0], 0}
        };
        for (int i = 1; i < nums.Length; i++)
        {
            int secondNumber = target - nums[i];
            if (pair.ContainsKey(secondNumber))
            {
                return new int[] { pair[secondNumber], i };
            }
            pair[nums[i]] = i;
        }
        return new int[] { };
    }
}

/// <explanation>
/// We will be using a dictionary in C# to store all the previous numbers in the list along indexes.
/// </explanation>
