using LeetCodeCSharp.BinarySearch;

namespace LeetCodeCSharp.Tests.BinarySearch;

public class KokoEatingBananaTests
{
    private readonly KokoEatingBanana solution;

    public KokoEatingBananaTests()
    {
        solution = new KokoEatingBanana();
    }

    [Theory]
    [InlineData(new int[] {3, 6, 7, 11}, 8, 4)]
    [InlineData(new int[] {30, 11, 23, 4, 20}, 5, 30)]
    [InlineData(new int[] {30, 11, 23, 4, 20}, 6, 23)]
    public void MinEatingSpeed_Example_ReturnMinK(int[] piles, int h, int expectedResult)
    {
        // Act 
        var result = solution.MinEatingSpeed(piles, h);

        // Assert
        Assert.Equal(result, expectedResult);
    }
}
