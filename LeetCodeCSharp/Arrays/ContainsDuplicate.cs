using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace LeetCodeCSharp.Arrays
{
    public class ContainsDuplicate
    {
        // brute force solution O(n^2) time complexity and O(1) space complexity
        public bool ContainsDuplicateBruteForce(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ( i != j && nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // optimized solution O(n) time complexity and O(n) space complexity
        public bool ContainsDuplicateOptimized(int[] nums)
        {
            var hashNums = new HashSet<int>(nums);
            if (hashNums.Count == nums.Length) return false;
            else return true;
        }
    }
}
