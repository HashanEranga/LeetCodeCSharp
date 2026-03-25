using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp.Arrays
{
    public class ValidAnagram
    {
        // brute force solution O(n) time complexity and O(n) space complexity
        public bool IsAnagramBruteForce(string s, string t)
        {
            var dictionaryS = new Dictionary<char, int>();
            var dictionaryT = new Dictionary<char, int>();

            foreach (char item in s)
            {
                if (dictionaryS.TryGetValue(item, out int value))
                    dictionaryS[item] = ++value;
                else
                    dictionaryS[item] = 1;
            }

            foreach (char item in t)
            {
                if (dictionaryT.TryGetValue(item, out int value))
                    dictionaryT[item] = ++value;
                else
                    dictionaryT[item] = 1;
            }

            if (dictionaryS.Count != dictionaryT.Count) return false;

            foreach (var item in dictionaryS)
            {
                if (!dictionaryT.ContainsKey(item.Key) || dictionaryT[item.Key] != item.Value) return false;
            }

            return true;
        }

        // improved time complexity but took much space due to hashing overhead O(n) time complexity and O(n) space complexity
        public bool IsAnagramOptimized(string s, string t)
        {
            var charFrequency = new Dictionary<char, int>();

            foreach (char item in s)
            {
                if (charFrequency.TryGetValue(item, out int value))
                    charFrequency[item] = ++value;
                else charFrequency[item] = 1;
            }

            foreach (char item in t)
            {
                if (charFrequency.TryGetValue(item, out int value))
                    charFrequency[item] = --value;
                else charFrequency[item] = -1;
            }

            foreach (var item in charFrequency)
            {
                if (item.Value != 0) return false;
            }

            return true;
        }

        // improved space complexity by sorting the char arrays and comparing them, but time complexity is O(n log n) due to sorting space complexity is O(1) if we ignore the space taken by sorting algorithm, otherwise it is O(n) due to the space taken by sorting algorithm
        public bool IsAnagramSortingReducedSpaceComplexity(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var charArrayS = s.ToCharArray();
            var charArrayT = t.ToCharArray();
            Array.Sort(charArrayS);
            Array.Sort(charArrayT);
            for (int i = 0; i < charArrayS.Length; i++)
            {
                if (charArrayS[i] != charArrayT[i]) return false;
            }

            return true;
        }
    }
}
