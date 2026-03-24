using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LeetCodeCSharp.Arrays;

namespace LeetCodeCSharp.Tests.Arrays
{
    public class TwoSumTests
    {
        private readonly TwoSum _twoSum;

        public TwoSumTests()
        {
            _twoSum = new TwoSum();
        }

        [Fact]
        public void TwoSumOptimized_Example1_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            // Act
            int[] result = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void TwoSumOptimized_Example2_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [3, 2, 4];
            int target = 6;

            // Act
            int[] result = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Contains(1, result);
            Assert.Contains(2, result);
        }

        [Fact]
        public void TwoSumOptimized_Example3_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [3, 3];
            int target = 6;

            // Act
            int[] result = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void TwoSumOptimized_WithNegativeNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [-1, -2, -3, -4, -5];
            int target = -8;

            // Act
            int[] result = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.True((nums[result[0]] + nums[result[1]]) == target);
        }

        [Fact]
        public void TwoSumOptimized_NoSolution_ReturnsEmptyArray()
        {
            // Arrange
            int[] nums = [1, 2, 3];
            int target = 10;

            // Act
            int[] result = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void TwoSumOptimized_LargeArray_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [1, 5, 3, 7, 9, 2, 4, 6, 8];
            int target = 15;

            // Act
            int[] result = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Equal(15, nums[result[0]] + nums[result[1]]);
        }

        [Fact]
        public void TwoSumBruteForce_Example1_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            // Act
            int[] result = _twoSum.TwoSumBruteForce(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void TwoSumBruteForce_Example2_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [3, 2, 4];
            int target = 6;

            // Act
            int[] result = _twoSum.TwoSumBruteForce(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Contains(1, result);
            Assert.Contains(2, result);
        }

        [Fact]
        public void TwoSumBruteForce_Example3_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [3, 3];
            int target = 6;

            // Act
            int[] result = _twoSum.TwoSumBruteForce(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Contains(0, result);
            Assert.Contains(1, result);
        }

        [Fact]
        public void TwoSumBruteForce_WithNegativeNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [-1, -2, -3, -4, -5];
            int target = -8;

            // Act
            int[] result = _twoSum.TwoSumBruteForce(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.True((nums[result[0]] + nums[result[1]]) == target);
        }

        [Fact]
        public void TwoSumBruteForce_NoSolution_ReturnsEmptyArray()
        {
            // Arrange
            int[] nums = [1, 2, 3];
            int target = 10;

            // Act
            int[] result = _twoSum.TwoSumBruteForce(nums, target);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void TwoSumBruteForce_LargeArray_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = [1, 5, 3, 7, 9, 2, 4, 6, 8];
            int target = 15;

            // Act
            int[] result = _twoSum.TwoSumBruteForce(nums, target);

            // Assert
            Assert.Equal(2, result.Length);
            Assert.Equal(15, nums[result[0]] + nums[result[1]]);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 3, 2, 4 }, 6)]
        [InlineData(new int[] { 3, 3 }, 6)]
        public void BothMethods_SameInput_ReturnValidSolution(int[] nums, int target)
        {
            // Act
            int[] optimizedResult = _twoSum.TwoSumOptimized(nums, target);
            int[] bruteForceResult = _twoSum.TwoSumBruteForce(nums, target);

            // Assert
            Assert.Equal(target, nums[optimizedResult[0]] + nums[optimizedResult[1]]);
            Assert.Equal(target, nums[bruteForceResult[0]] + nums[bruteForceResult[1]]);
        }
    }
}
