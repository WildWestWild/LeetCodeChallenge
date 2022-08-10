namespace LeetCodeСhallenge.LeetCode;

public class FirstBadVersionTask
{
    private List<bool> _arrayOfBadVersions;
    
    public FirstBadVersionTask(bool[] arrayOfBadVersions)
    {
        _arrayOfBadVersions = new List<bool>(arrayOfBadVersions);
    }

    public FirstBadVersionTask(int maxLength, int firstBad)
    {
        _arrayOfBadVersions = new List<bool>();
        for (int i = 1; i <= maxLength; i++)
        {
            _arrayOfBadVersions.Add((i >= firstBad));
        }
    }
    
    private bool IsBadVersion(int n)
    {
        return _arrayOfBadVersions[n-1];
    }
    
    public int FirstBadVersion(int n)
    {
        long startIndex = 1;
        long endIndex = n - 1;
        int targetIndex = default;
        bool targetIsBadVersion = false;
        bool prevIsBadVersion = false;
        
        
        if(IsBadVersion(1)){
            return 1;
        }

        do
        {
            long sumIndex = endIndex + startIndex;
            targetIndex = (int)
            (
                sumIndex % 2 == 0
                ? (sumIndex) / 2
                : (sumIndex) / 2 + 1
            );

            targetIsBadVersion = IsBadVersion(targetIndex);
            
            prevIsBadVersion = IsBadVersion(targetIndex - 1);

            if (( targetIsBadVersion && prevIsBadVersion == false ))
            {
                return targetIndex;
            }
            
            if (targetIsBadVersion)
                endIndex = --targetIndex;
            else
                startIndex = ++targetIndex;

        } while ( true);
    }
}