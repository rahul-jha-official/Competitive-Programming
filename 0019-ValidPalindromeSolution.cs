using System.Text;

/// <description>
/// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
/// Given a string s, return true if it is a palindrome, or false otherwise.
/// 
/// Example 1:
/// Input: s = "A man, a plan, a canal: Panama"
/// Output: true
/// 
/// Example 2:
/// Input: s = "race a car"
/// Output: false
/// 
/// Example 3:
/// Input: s = " "
/// Output: true
/// </description>
public class ValidPalindromeSolution
{
    public bool IsPalindrome(string s)
    {
        var sbr = new StringBuilder();
        var i = 0;
        foreach (var c in s) sbr.AppendIfAlphanumeric(c);
        for (; i < sbr.Length / 2 && sbr[i] == sbr[sbr.Length - 1 - i]; i++) ;
        return i == (sbr.Length / 2);
    }
}

public static class Extensions
{
    public static void AppendIfAlphanumeric(this StringBuilder sb, char ch)
    {
        if ((ch >= '0' && ch <= '9') || (ch >= 'a' && ch <= 'z'))
        {
            sb.Append(ch);
            return;
        }

        if (ch >= 'A' && ch <= 'Z')
        {
            sb.Append((char)(ch + 32));
        }
    }
}

/// <explanation>
/// Add Required character to some other container and then check Palindrome.
/// </explanation>
