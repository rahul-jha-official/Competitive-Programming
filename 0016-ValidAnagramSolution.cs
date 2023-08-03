/// <description>
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
/// 
/// Example 1:
/// Input: s = "anagram", t = "nagaram"
/// Output: true
/// 
/// Constraints:
/// 1 <= s.length, t.length <= 5 * 104
/// s and t consist of lowercase English letters.
/// </description>
public class ValidAnagramSolution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        var frequencies = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            int i1 = s[i] - 'a', i2 = t[i] - 'a';
            frequencies[i1]++;
            frequencies[i2]--;
        }

        foreach (var frequencie in frequencies)
        {
            if (frequencie != 0) return false;
        }

        return true;
    }

    public bool IsAnagramSimple(string s, string t)
    {
        return s.Sort().Equals(t.Sort());
    }
}

public static class MyExtensions
{
    public static string Sort(this string s)
    {
        var sArray = s.ToCharArray();
        Array.Sort(sArray);
        return new string(sArray);
    }
}

/// <explanation>
/// There are two solution to get it done.
/// 1. Compare the frequencies
/// 2. Sort and Compare both string
/// </explanation>
