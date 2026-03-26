using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp.Arrays
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramsOptimized(string[] strs)
        {
            var anagramsDict = new Dictionary<string, List<string>>();
            foreach (string item in strs)
            {
                var charArray = item.ToCharArray();
                Array.Sort(charArray);
                var sortedString = new string(charArray);

                if (!anagramsDict.ContainsKey(sortedString)) anagramsDict[sortedString] = new List<string>();
                anagramsDict[sortedString].Add(item);
            }

            var result = new List<IList<string>>();
            foreach (var item in anagramsDict)
            {
                result.Add(item.Value);
            }

            return result;
        }
    }
}
