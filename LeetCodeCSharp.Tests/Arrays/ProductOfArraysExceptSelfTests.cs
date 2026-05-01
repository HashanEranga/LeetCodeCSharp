using LeetCodeCSharp.Arrays;

namespace LeetCodeCSharp.Tests.Arrays;

public class ProductOfArraysExceptSelfTests
{
    private readonly ProductOfArraysExceptSelf solution = new();

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    public void ProductExceptSelf_TODO_DescribeCase(int[] nums, int[] expected)
    {
        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
