/// <description>
/// Given an integer array nums, find a subarray that has the largest product, and return the product.
/// The test cases are generated so that the answer will fit in a 32-bit integer.
/// 
/// Example 1:
/// Input: nums = [2, 3, -2, 4]
/// Output: 6
/// Explanation: [2,3] has the largest product 6.
/// 
/// Example 2:
/// Input: nums = [-2, 0, -1]
/// Output: 0
/// Explanation: The result cannot be 2, because[-2, -1] is not a subarray.
/// 
/// Constraints:
/// 1 <= nums.length <= 2 * 104
/// -10 <= nums[i] <= 10
/// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
/// 
/// </description>

public class MaximumProductSubarraySolution
{
    public int MaxProduct(int[] nums)
    {
        int min = 1, max = 1, maxProduct = nums.Max();
        foreach (int n in nums)
        {
            if (n == 0)
            {
                max = min = 1;
                continue;
            }
            int temp = Max(max * n, min * n, n);
            min = Min(max * n, min * n, n);
            max = temp;
            maxProduct = Math.Max(max, maxProduct);
        }
        return maxProduct;
    }

    private int Max(int i, int j, int k)
    {
        return Math.Max(i, Math.Max(j, k));
    }

    private int Min(int i, int j, int k)
    {
        return Math.Min(i, Math.Min(j, k));
    }
}

/// <explanation>
/// If there are only positive number so getting the max product is pretty straight forward, Just multiple all elements.
/// If there are only negative number so getting the max product is little bit complex, as if there are even number of item in the array then multply 
/// all the elements directly as 2 negative sign cancel each other but for odd number of item in array we have to find the product and divide by Max item in the array. Eg. 
/// 
/// int product = 1;
/// foreach (int item in nums) product = product * i;
/// return product / nums.Max();
/// 
/// In case of mix numbers we have to find an approach, as we do not want to go with calculating the product of every subarray;
/// The optimal sulation of this problem will be calculating the Min and Max Product at each points and if the number is 0 then we have to reset Min and Max to 1.
/// 
/// </explanation>
