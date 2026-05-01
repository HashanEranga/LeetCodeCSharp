using LeetCodeCSharp.Arrays;

namespace LeetCodeCSharp.Tests.Arrays;

public class LongestConsecutiveSequenceTests
{
    private readonly LongestConsecutiveSequence solution = new();

    [Theory]
    [InlineData(new int[]{ 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new int[]{ 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    [InlineData(new int[]{ 1, 0, 1, 2 }, 3)]

    public void LongestConsecutive_TODO_DescribeCase(int[] nums, int expected)
    {
        // Act
        var result = solution.LongestConsecutive(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
