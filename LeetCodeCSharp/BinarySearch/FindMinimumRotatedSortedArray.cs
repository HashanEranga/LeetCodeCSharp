namespace LeetCodeCSharp.BinarySearch;

public class FindMinimumRotatedSortedArray
{
    public int FindMin(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start < end)
        {
            int mid = (start + end) / 2;

            if (nums[mid] <= nums[end])
            {
                end = mid;
            }
            else
            {
                start = mid + 1;
            }
        }

        return nums[start];
    }
}
