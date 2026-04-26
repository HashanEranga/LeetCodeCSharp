using System.Text.RegularExpressions;

namespace LeetCodeCSharp.TwoPointers;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var preProcessedArr = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower().ToArray();

        for(int i = 0; i < preProcessedArr.Length; i++)
        {
            int j = preProcessedArr.Length - i - 1;
            if(i >= j)
            {
                if(preProcessedArr[i] != preProcessedArr[j]) return false;
            }
        }

        return true;

    }
}