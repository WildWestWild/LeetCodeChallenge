namespace LeetCodeСhallenge.LeetCode;

public class ValidParenthesesTask
{
    public bool IsValid(string s)
    {
        var stackChars = new Stack<char>();
        stackChars.Push(s[0]);
        
        for (int i = 1; i < s.Length; i++)
        {
            if (!stackChars.Any())
            {
                stackChars.Push(s[i]);
                continue;
            }
            
            var parenthese = stackChars.Peek();
            if (CheckСouple(parenthese, s[i]))
                stackChars.Pop();
            else
                stackChars.Push(s[i]);
        }

        return stackChars.Count == default;
    }

    private bool CheckСouple(char firstP, char secondP)
    {
        switch (secondP)
        {
            case ')': return firstP == '(';
            case '}': return firstP == '{';
            case ']': return firstP == '[';
            default: return false;
        }
    }
}