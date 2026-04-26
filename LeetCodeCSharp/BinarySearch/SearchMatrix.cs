namespace LeetCodeCSharp.BinarySearch;

public class SearchMatrix
{
    public bool SearchMatrixSol(int[][] matrix, int target)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix[0].Length;

        int start = 0;
        int end = numRows * numCols - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;

            int row = mid / numCols;
            int col = mid % numCols;

            if (matrix[row][col] == target)
                return true;
            else if (matrix[row][col] < target)
                start = mid + 1;
            else
                end = mid - 1;
        }

        return false;
    }
}
