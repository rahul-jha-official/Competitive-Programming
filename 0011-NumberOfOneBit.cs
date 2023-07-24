/// <summary>
/// Write a function that takes the binary representation of an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
/// 
/// Example 1:
/// Input: n = 00000000000000000000000000001011
/// Output: 3
/// Explanation: The input binary string 00000000000000000000000000001011 has a total of three '1' bits.
/// 
/// Example 2:
/// Input: n = 00000000000000000000000010000000
/// Output: 1
/// Explanation: The input binary string 00000000000000000000000010000000 has a total of one '1' bit.
/// 
/// Example 3:
/// Input: n = 11111111111111111111111111111101
/// Output: 31
/// Explanation: The input binary string 11111111111111111111111111111101 has a total of thirty one '1' bits.
/// 
/// Constraints:
/// The input must be a binary string of length 32.
/// </summary>
public class NumberOfOneBit
{
    public int HammingWeight(uint n)
    {
        int numberOfOneBit = 0;
        while (n > 0)
        {
            numberOfOneBit += (int)(n & 1);
            n >>= 1;
        }
        return numberOfOneBit;
    }
}
/// <description>
/// The problem is straight forward, as we need to count 1, we should check the last digit by (n & 1) and then shift n to right by (n >> 1).
/// Repeat the process until the n becomes 0.
/// </description>
