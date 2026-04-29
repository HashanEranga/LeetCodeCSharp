namespace LeetCodeCSharp.BinarySearch;

public class KokoEatingBanana
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int end = FindMax(piles);
        int start = 1;

        while (start < end)
        {
            int k = (start + end) / 2;
            int hoursTaken = 0;
            foreach (int pile in piles)
            {
                hoursTaken += (int)Math.Ceiling((double) pile / k);
            }

            if (hoursTaken <= h)
            {
                end = k;
            }
            else
            {
                start = k + 1;
            }
        }

        return start;
    }

    public int FindMax(int[] nums)
    {
        int max = int.MinValue;

        foreach(int value in nums)
            if (max < value)
                max = value;

        return max;
    }
}
