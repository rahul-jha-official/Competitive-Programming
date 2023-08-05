using System.Collections.Immutable;

/// <description>
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// 
/// An input string is valid if:
/// Open brackets must be closed by the same type of brackets.
/// Open brackets must be closed in the correct order.
/// Every close bracket has a corresponding open bracket of the same type.
/// 
/// Example 1:
/// Input: s = "()"
/// Output: true
/// 
/// Example 2:
/// Input: s = "()[]{}"
/// Output: true
/// 
/// Example 3:
/// Input: s = "(]"
/// Output: false
/// 
/// Constraints:
/// 1 <= s.length <= 104
/// s consists of parentheses only '()[]{}'.
/// 
/// </description>
public class ValidParenthesesSolution
{
    private readonly static IEnumerable<char> brackets = new List<char> { ')', '}', ']' };
    public bool IsValid(string s)
    {
        var IsReverse = (char bracket) => brackets.Contains(bracket);
        var GetReverse = (char bracket) => bracket switch
        {
            ')' => '(',
            '}' => '{',
            ']' => '[',
            _ => throw new NotImplementedException()
        };

        var stack = new Stack<char>();
        foreach (char bracket in s)
        {
            if (IsReverse(bracket))
            {
                if (!stack.Any() || stack.Peek() != GetReverse(bracket)) return false;
                stack.Pop();
            }
            else stack.Push(bracket);
        }
        return !stack.Any();
    }
}

/// <explanation>
/// The problem can be solved using Stack [LIFO - Last In First Out]
/// So approach will be straight forward, iterate over the string characters and add bracket to stack if it is opening bracket '(' , '{' or '['
/// Otherwise remove for the stack if reverse if the reverse bracket matches the top of the stack.
/// If at last stack is empty return true.
/// </explanation>
