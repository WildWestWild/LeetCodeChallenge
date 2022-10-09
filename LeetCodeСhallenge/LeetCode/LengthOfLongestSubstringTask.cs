namespace LeetCodeСhallenge.LeetCode;

public static class LengthOfLongestSubstringTask
{
    private static HashSet<char> _hashSet = new HashSet<char>();
    public static int LengthOfLongestSubstring(string s)
    {
        var sLength = s.Length;
        int resultLength = sLength;
    
        if (sLength > 1)
        {
            int lastElemIndex = sLength - 1;
            int startIndex = default;
            int stringIterator = default;
            int currentSubLength = resultLength = 1;
            
            while (startIndex < lastElemIndex)
            {
                if (CheckInHashSet(s[stringIterator]))
                {
                    stringIterator++;
                    currentSubLength = _hashSet.Count;
                    if (resultLength < currentSubLength) resultLength = currentSubLength;
                }
                else
                {
                    startIndex++;
                    stringIterator = startIndex;
                }
                
                if (startIndex + currentSubLength >= lastElemIndex) break;
            }
        }
    
        return resultLength;
    }
    
    private static bool CheckInHashSet(char checkedChar)
    {
        bool contains = _hashSet.Contains(checkedChar);
        if (contains)
        {
            _hashSet = new HashSet<char>();
            return false;
        }

        _hashSet.Add(checkedChar);
        return true;
    }
}