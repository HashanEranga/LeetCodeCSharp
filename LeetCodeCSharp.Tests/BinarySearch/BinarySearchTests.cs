using LeetCodeCSharp.BinarySearch;

namespace LeetCodeCSharp.Tests.BinarySearch;

public class BinarySearchTests
{
    private readonly BinarySearchImpl binarySearchSol;
    public BinarySearchTests()
    {
        binarySearchSol = new BinarySearchImpl();
    }

    [Theory]
    [InlineData(new int[]{-1, 0, 3, 5, 9, 12}, 9, 4)]
    [InlineData(new int[]{-1, 0, 3, 5, 9, 12}, 2, -1)]
    public void BasicCaseInBinSearch_BinarySearchMethod_ReturnsExpectedResult(int[] nums, int target, int expectedIndex)
    {
        // Act 
        var result = binarySearchSol.Search(nums, target);

        // Assert 
        Assert.Equal(expectedIndex, result);
    }
}