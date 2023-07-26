/// <description>
/// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
/// 
/// Example 1:
/// Input: nums = [3,0,1]
/// Output: 2
/// Explanation: n = 3 since there are 3 numbers, so all numbers are in the range[0, 3]. 2 is the missing number in the range since it does not appear in nums.
/// 
/// Example 2:
/// Input: nums = [9,6,4,2,3,5,7,0,1]
/// Output: 8
/// Explanation: n = 9 since there are 9 numbers, so all numbers are in the range[0, 9]. 8 is the missing number in the range since it does not appear in nums.
/// 
/// Constraints:
/// n == nums.length
/// 1 <= n <= 104
/// 0 <= nums[i] <= n
/// All the numbers of nums are unique./// 
/// </description>

public class MissingNumberSolution
{
    public int MissingNumber(int[] nums)
    {
        int length = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == i) continue;
            while (nums[i] < length && nums[i] != i)
            {
                (nums[i], nums[nums[i]]) = (nums[nums[i]], nums[i]);
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i != nums[i]) return i;
        }
        return length;
    }
}

/// <explanation>
/// So by looking at description, it look like we need to sort the array. But as mentioned we are not allowed to use another array. As we are having
/// number between range [0,n] then we can sort using the number, we just need to put the number at its index. 
/// </explanation>
