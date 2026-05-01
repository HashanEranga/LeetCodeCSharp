namespace LeetCodeCSharp.Arrays;

public class LongestConsecutiveSequence
{
    // TODO: time complexity / space complexity
    public int LongestConsecutive(int[] nums)
    {
        var hashNums = new HashSet<int>(nums);
        int maxSeqLen = 0;

        foreach (var item in hashNums)
        {
            int currentItem = item;
            if (!hashNums.Contains(item - 1))
            {
                int seqLen = 0;
                while (hashNums.Contains(currentItem))
                {
                    currentItem++;
                    seqLen++;
                }
                if(seqLen > maxSeqLen) maxSeqLen = seqLen;
            }
        }
        return maxSeqLen;
    }
}
