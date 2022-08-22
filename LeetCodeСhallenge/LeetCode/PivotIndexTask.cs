

namespace LeetCodeСhallenge.LeetCode;

public static class PivotIndexTask
{
    public static int PivotIndex(int[] nums)
    {
        var leftSum = 0;
        var allSum = nums.Sum();
        var lenghtNum = nums.Length;

        for (int i = 0; i < lenghtNum; i++)
        {
            if (leftSum == allSum - leftSum - nums[i]) return i;
            leftSum += nums[i];
        }

        return -1;
    }
}