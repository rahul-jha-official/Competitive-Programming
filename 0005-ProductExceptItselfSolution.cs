/// <description>
/// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
/// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
/// You must write an algorithm that runs in O(n) time and without using the division operation.
/// 
/// Example 1:
/// Input: nums = [1,2,3,4]
/// Output: [24,12,8,6]
/// 
/// Example 2:
/// Input: nums = [-1,1,0,-3,3]
/// Output: [0,0,9,0,0]
/// 
/// </description>
public class ProductExceptItselfSolution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int leftProduct = 1, rightProduct = 1;
        left[0] = right[nums.Length - 1] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            leftProduct *= nums[i - 1];
            rightProduct *= nums[nums.Length - i];
            left[i] = leftProduct;
            right[nums.Length - 1 - i] = rightProduct;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = left[i] * right[i];
        }

        return nums;
    }
}
/// <explnation>
/// Product of left side of array product and left side of array product is equal to Product of Array Except Self
/// </explnation>
