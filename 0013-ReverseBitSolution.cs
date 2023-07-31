/// <description>
/// Reverse bits of a given 32 bits unsigned integer.
/// 
/// Example 1:
/// Input:  n = 00000010100101000001111010011100
/// Output: 964176192 (00111001011110000010100101000000)
/// 
/// Example 2:
/// Input:  n = 11111111111111111111111111111101
/// Output: 3221225471 (10111111111111111111111111111111)
/// 
/// Constraints:
/// The input must be a binary string of length 32
/// </description>

public class ReverseBitSolution
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 32; i++)
        {
            uint lastBit = (n >> i) & 1;
            result |= lastBit << (31 - i);
        }
        return result;
    }
}

/// <explaination>
/// To reverse bit we need an empty bucket, lets have result = 0.
/// result = 00000000000000000000000000000000, Assume result as bucket of 32 zeros
/// Iterate over the bits and concatenate the bit after shifting it to right at certain position. 
/// </explaination>
