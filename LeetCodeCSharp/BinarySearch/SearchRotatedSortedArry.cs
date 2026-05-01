namespace LeetCodeCSharp.BinarySearch;

public class SearchRotatedSortedArry
{
    // TODO: time complexity / space complexity
    public int Search(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length-1;

        while (start <= end)
        {
            int mid = (start+end)/2;

            if (nums[mid] < nums[end]) // right side is sorted
            {
                if (nums[mid] == target) return mid;
                if (target >= nums[mid] && target <= nums[end]) start = mid+1; // check target within the right sorted array
                else end = mid-1;
            }
            else // left side is sorted
            {
                if (nums[mid] == target) return mid;
                if (target <= nums[mid] && target >= nums[start]) end = mid-1; // check target within the left sorted array
                else start = mid+1;
            }
        }

        return -1;
    }
}
