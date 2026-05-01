using LeetCodeCSharp.BinarySearch;

namespace LeetCodeCSharp.Tests.BinarySearch;

public class FindMinimumRotatedSortedArrayTests
{
    private readonly FindMinimumRotatedSortedArray solution = new();

    [Theory]
    [InlineData(new int[]{ 3, 4, 5, 1, 2 }, 1)]
    [InlineData(new int[]{ 4, 5, 6, 7, 0, 1, 2 }, 0)]
    [InlineData(new int[]{ 11, 13, 15, 17 }, 11)]
    public void FindMin_TODO_DescribeCase(int[] nums, int expected)
    {
        // Act
        var result = solution.FindMin(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
