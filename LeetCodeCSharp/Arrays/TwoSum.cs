using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp.Arrays
{
    public class TwoSum
    {
        // optimized solution O(n) and O(n) space complexity
        public int[] TwoSumOptimized(int[] nums, int target)
        {
            var hashNums = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashNums.ContainsKey(complement))
                {
                    return new int[] { hashNums[complement], i };
                }

                hashNums[nums[i]] = i;
            }

            return new int[] {};
        }

        // brute force solution O(n^2) time complexity and O(1) space complexity
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;
                    else
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new[] { i, j };
                        }
                    }
                }
            }

            return new int[]{};
        }

    }
}
