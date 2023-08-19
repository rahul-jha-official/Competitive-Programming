/// <description>
/// Given an unsorted integer array nums, return the smallest missing positive integer.
/// You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.
/// 
/// Example 1:
/// Input: nums = [1,2,0]
/// Output: 3
/// Explanation: The numbers in the range[1, 2] are all in the array.
/// 
/// Example 2:
/// Input: nums = [3, 4, -1, 1]
/// Output: 2
/// Explanation: 1 is in the array but 2 is missing.
/// 
/// Example 3:
/// Input: nums = [7, 8, 9, 11, 12]
/// Output: 1
/// Explanation: The smallest positive integer 1 is missing.
/// 
/// Constraints:
/// 1 <= nums.length <= 105
/// -231 <= nums[i] <= 231 - 1
/// </description>
public class FirstMissingPositiveSolution
{
    public int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] >= 0 ? nums[i] : 0;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums.IsValidIndex(index))
            {
                nums[index] = nums[index] == 0 ? (nums.Length + 2) * -1 : Math.Abs(nums[index]) * -1;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0)
            {
                return i + 1;
            }
        }
        return nums.Length + 1;
    }
}

public static class FirstMissingPositiveExtensions
{
    public static bool IsValidIndex(this int[] a, int index) => index > -1 && index < a.Length;
}

/// <explanation>
/// The idea behind this problem is the array itself. You can keep atmax 1 to n [n is size]. 
/// Suppose array is [1,2,3,4] now it is clear 5 is first missing. 
/// Suppose array is [0,1,3,4], now 2 is missing, how to figure it out ??
/// We will approach this problem by changing the number's index to negative sign.
/// In this case [0,1,3,4], 0 is skipped, for 1 index will be 0, changing array's 0 index with negative value, for 3 index will be 2, change 2nd index with negative value.
/// Finally array will be [-6,1,-3,-4], Return positive index + 1 which will be 2
/// </explanation>
