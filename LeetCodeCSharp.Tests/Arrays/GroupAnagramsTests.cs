using System;
using System.Collections.Generic;
using System.Text;
using LeetCodeCSharp.Arrays;

namespace LeetCodeCSharp.Tests.Arrays
{
    public class GroupAnagramsTests
    {
        private readonly GroupAnagrams _solution = new GroupAnagrams();
        public GroupAnagramsTests()
        {
            _solution = new GroupAnagrams();
        }

        public static IEnumerable<object[]> GroupAnagramsTestData()
        {
            yield return new object[]
            {
                new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new List<IList<string>>
                {
                    new List<string> { "bat" },
                    new List<string> { "nat", "tan" },
                    new List<string> { "ate", "eat", "tea" }
                }
            };
        }

        [Theory]
        [MemberData(nameof(GroupAnagramsTestData))]
        public void GroupAnagramsOptimized_ShouldReturnExpectedResult(string[] input, List<IList<string>> expected)
        {
            var result = _solution.GroupAnagramsOptimized(input);

            Assert.Equal(expected.Count, result.Count);
        }
    }
}