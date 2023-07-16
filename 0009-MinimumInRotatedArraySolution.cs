/// <description>
/// Suppose an array of length n sorted in ascending order is rotated between 1 and n times.For example, the array nums = [0, 1, 2, 4, 5, 6, 7] might become: 
/// [4,5,6,7,0,1,2] if it was rotated 4 times.
/// [0, 1, 2, 4, 5, 6, 7] if it was rotated 7 times.
/// Notice that rotating an array[a[0], a[1], a[2], ..., a[n - 1]] 1 time results in the array[a[n - 1], a[0], a[1], a[2], ..., a[n - 2]].
/// Given the sorted rotated array nums of unique elements, return the minimum element of this array.
/// You must write an algorithm that runs in O(log n) time.
/// 
/// Example 1:
/// Input: nums = [3, 4, 5, 1, 2]
/// Output: 1
/// 
/// Example 2:
/// Input: nums = [4, 5, 6, 7, 0, 1, 2]
/// Output: 0
/// 
/// Example 3:
/// Input: nums = [11, 13, 15, 17]
/// Output: 11
/// 
/// Constraints:
/// n == nums.length
/// 1 <= n <= 5000
/// -5000 <= nums[i] <= 5000
/// All the integers of nums are unique.
/// nums is sorted and rotated between 1 and n times.
/// </description>

public class MinimumInRotatedArraySolution
{
    public int FindMin(int[] nums)
    {
        int low = 0, high = nums.Length - 1;
        while (low < high)
        {
            int mid = (high - low) / 2 + low;
            if (mid > 0 && nums[mid - 1] > nums[mid]) return nums[mid];
            if (nums[low] <= nums[mid])
            {
                if (nums[low] > nums[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            else
            {
                if (nums[low] > nums[high])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }
        return nums[low];
    }
}
