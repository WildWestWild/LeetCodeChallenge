namespace LeetCodeСhallenge.LeetCode;

public static class PivotIndexTask
{
    public static int  PivotIndex(int[] nums)
    {
        var numsLength = nums.Length;
        
        if (IsFirstPivotIndex(nums)) return 0;

        if (IsLastPivotIndex(nums)) return numsLength - 1;

        var firstIndex = 1;
        var lastIndex = nums.Length - 2;

        for (int i = firstIndex; i <= lastIndex; i++)
        {
            var firstPart = nums.SkipLast(numsLength - i).Sum();
            var secondPart = nums.Skip(i + 1).Sum();

            if (firstPart == secondPart)
            {
                return i;
            }
        }

        return -1;
    }

    private static bool IsFirstPivotIndex(int[] nums) => 0 == nums.Skip(1).Sum();

    private static bool IsLastPivotIndex(int[] nums) => 0 == nums.SkipLast(1).Sum();
}