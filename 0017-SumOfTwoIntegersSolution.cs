/// <description>
/// Given two integers a and b, return the sum of the two integers without using the operators + and -.
/// 
/// Example 1:
/// Input: a = 1, b = 2
/// Output: 3
/// 
/// Example 2:
/// Input: a = 2, b = 3
/// Output: 5
/// 
/// Constraints:
/// -1000 <= a, b <= 1000
/// </description>
public class SumOfTwoIntegersSolution
{
    public int GetSum(int a, int b)
    {
        if (Math.Abs(a) == Math.Abs(b) && (a * b) < 0) return 0;
        if (a == b) return 2 * a;
        while (b != 0)
        {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }
}
/// <explanation>
/// From the description it is clear that we have to use Bitwise operator as we cannot use + or - operator.
/// For Calculating the carry we will be using Bitwise &.
/// For Calculting the sum we will be using Bitwise ^.
/// For next iteration value we will be shifting the value to left.
/// 
/// If two number are same then we can use multiply.
/// If two number are same and opposite in sign then we can return 0.
/// </explanation>
