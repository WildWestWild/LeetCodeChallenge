namespace LeetCodeСhallenge.LeetCode;

public static class HappyNumberTask
{
    public static bool IsHappy(int n)
    {
        double digitSquareSum;
        int countAttempts = default;
        try
        {
            while (n != 1)
            {
                digitSquareSum = default;
                if (countAttempts == 100000000) return false;
                
                while (n > 0)
                {
                    digitSquareSum += Math.Pow(n % 10, 2);
                    n /= 10;
                }
                countAttempts++;
                
                n = (int) digitSquareSum;
            }
        }
        catch
        {
            return false;
        }

        return true;
    }
}