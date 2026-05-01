using LeetCodeCSharp.BinarySearch;

namespace LeetCodeCSharp.Tests.BinarySearch;

public class SearchRotatedSortedArryTests
{
    private readonly SearchRotatedSortedArry solution = new();

    [Theory]
    [InlineData(new int[]{ 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    public void Search_TODO_DescribeCase(int[] nums, int target, int expected)
    {
        
        // Act
        var result = solution.Search(nums, target);
        // Assert
        Assert.Equal(expected, result);
    }
}
