namespace LeetCodeCSharp.BinarySearch;

public class KokoEatingBanana
{
    // TODO: time complexity / space complexity
    public int MinEatingSpeed(int[] piles, int h)
    {
        int end = FindMax(piles);
        int start = 1;

        while (start > end)
        {
            int k = (start + end) / 2;
            int hoursTaken = 0;
            foreach (int pile in piles)
            {
                if (pile < k)
                {
                    hoursTaken += 1;
                }
                else
                {
                    hoursTaken += (pile/k);
                }
            }

        }
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
