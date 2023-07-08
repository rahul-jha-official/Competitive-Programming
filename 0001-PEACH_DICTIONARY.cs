/// <description>
/// consider a new language whose alphabet contains only 5 characters: 'p','e','a','c','h'.
/// 'p' comes before 'e', 'e' comes before 'a', 'a' comes before 'c' and 'c' comes before 'h'. 1st word in the language dictionary is 'p'. 
/// 2nd word is 'e'. and so on... 6th word is 'pp'. 7th word is 'pe'. and so on...given n(1 <= n <= 10^9). 
/// Find the nth word in this language dictionary.
/// 
/// Example:
/// Input: 7
/// Output: PE
/// </description>

using System;
using System.Text;
public class PEACH_Dictionary
{
    public static void Main()
    {
        long index = 30;
        string word = new PEACH_Dictionary().GetWord(index);
        Console.WriteLine($"Word at index {index}: {word}");
    }
    public string GetWord(long n)
    {
        char[] ch = { 'P', 'E', 'A', 'C', 'H' };
        long divisor = 5;
        long divident = n;
        StringBuilder sbr = new StringBuilder();
        while (divident > divisor)
        {
            long modulus = divident % divisor;
            if (modulus == 0)
            {
                sbr.Insert(0, ch[ch.Length - 1]);
                divident -= 5;
            }
            else
            {
                sbr.Insert(0, ch[modulus - 1]);
            }
            divident /= divisor;
        }

        if (divident > 0)
        {
            sbr.Insert(0, ch[divident - 1]);
        }

        return sbr.ToString();
    }
}

/// <explanation>
/// Word with single character  : 1   - 5   => a.5^0
/// Word with two character     : 6   - 30  => a.5^0 + b.5^1
/// Word with three character   : 31  - 155 => a.5^0 + b.5^1 + c.5^2
/// Word with four character    : 156 - 780 => a.5^0 + b.5^1 + c.5^2 + d.5^3
/// Note: a, b, c, d... can have value [1-5]
///
/// Example:
/// 28 => 3.5^0 + 5.5^1 :: a = 3, b = 5 :: Character at 3rd place is A and Character at 5th place is H :: word is HA
/// 42 => 2.5^0 + 3.5^1 + 1.5^2 :: a = 2, b = 3, c = 1 :: Character at 2nd place is E, Character at 3rd place is A and Character at 1st place is P :: word is PAE
/// </explanation>
