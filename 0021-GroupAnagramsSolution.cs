/// <description>
/// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
/// 
/// Example 1:
/// Input: strs = ["eat","tea","tan","ate","nat","bat"]
/// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
/// 
/// Example 2:
/// Input: strs = [""]
/// Output: [[""]]
/// 
/// Example 3:
/// Input: strs = ["a"]
/// Output: [["a"]]
/// 
/// Constraints:
/// 1 <= strs.length <= 104
/// 0 <= strs[i].length <= 100
/// strs[i] consists of lowercase English letters.
/// </description>
public class GroupAnagramsSolution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string,IList<string>> pairs = new Dictionary<string,IList<string>>();
        foreach (string str in strs)
        {
            string sorted = str.Sort();
            if (!pairs.ContainsKey(sorted))
            {
                pairs.Add(sorted, new List<string>());
            }
            pairs[sorted].Add(str);
        }
        return pairs.Select(e => e.Value).ToList();
    }
}

public static class GroupAnagramsSolutionExtensions
{
    public static string Sort(this string s)
    {
        var chs = s.ToCharArray();
        Array.Sort(chs);
        return string.Join("", chs);
    }
}

/// <explanation>
/// Simplest solution will be to sort the string and add string to the dictionary with value of list and key as Sorted value. 
/// </explanation>
