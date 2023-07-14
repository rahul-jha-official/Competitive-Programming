/// <description>
/// Given an integer array nums, find the subarray with the largest sum, and return its sum.
/// 
/// Example 1:
/// Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
/// Output: 6
/// Explanation: The subarray [4,-1,2,1] has the largest sum 6.
/// 
/// Example 2:
/// Input: nums = [5,4,-1,7,8]
/// Output: 23
/// Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
/// 
/// Example 3:
/// Input: nums = [-3,-1,-2]
/// Output: -1
/// Explanation: The subarray [-1] has the largest sum -1.
/// 
/// Example 4:
/// Input: nums = [-3,-1,-2, 0]
/// Output: 0
/// Explanation: The subarray [0] has the largest sum 0.
/// </description>

public class MaximumSubarraySolution
{
    public int MaxSubArray(int[] nums)
    {
        int max = nums[0], sum = 0;
        foreach (int n in nums)
        {
            if (sum < 0) sum = 0;
            sum += n;
            max = Math.Max(sum, max);
        }
        return max;
    }
}

/// <description>
/// Find the sum and if sum become below zero set the sum as 0 and find the max at every step.
/// </description>
