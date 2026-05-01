namespace LeetCodeCSharp.Arrays;

public class ProductOfArraysExceptSelf
{
    // TODO: time complexity / space complexity
    public int[] ProductExceptSelf(int[] nums)
    {
        var mult = 1;
        var leftPass = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0) leftPass[0] = 1;
            else leftPass[i] = leftPass[i-1]*nums[i-1];
        }

        for (int i = nums.Length - 1 ; i >= 0; i--)
        {
            if(i == nums.Length - 1) leftPass[i] *= mult;
            else
            {
                mult = mult * nums[i + 1];
                leftPass[i] *= mult;
            }
        }

        return leftPass;
    }
}
