using LeetCodeCSharp.BinarySearch;

namespace LeetCodeCSharp.Tests.BinarySearch;

public class SearchMatrixTests
{
    private readonly SearchMatrix searchMatrix;

    public SearchMatrixTests()
    {
        searchMatrix = new SearchMatrix();
    }

    public static IEnumerable<object[]> MatrixData => new List<object[]>
    {
        new object[] { new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] }, 3, true },
        new object[] { new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] }, 13, false }
    };

    [Theory]
    [MemberData(nameof(MatrixData))]
    public void BasicCaseInSearchMatrix_SearchMatrixSol_ReturnExpectedBoolean(int[][] matrix, int target, bool expectedValue)
    {
        var result = searchMatrix.SearchMatrixSol(matrix, target);

        Assert.Equal(expectedValue, result);
    }
}
