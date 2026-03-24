using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LeetCodeCSharp.Arrays;

namespace LeetCodeCSharp.Tests.Arrays
{
    public class ContainsDuplicateTests
    {
        private readonly ContainsDuplicate _containsDuplicate;

        public ContainsDuplicateTests()
        {
            _containsDuplicate = new ContainsDuplicate();
        }

        [Fact]
        public void ContainsDuplicateBruteForce_WithDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 2, 3, 1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_WithoutDuplicates_ReturnsFalse()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_WithMultipleDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_EmptyArray_ReturnsFalse()
        {
            // Arrange
            int[] nums = [];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_SingleElement_ReturnsFalse()
        {
            // Arrange
            int[] nums = [1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_TwoIdenticalElements_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_WithNegativeNumbers_ReturnsTrue()
        {
            // Arrange
            int[] nums = [-1, -2, -3, -1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_WithNegativeNumbersNoDuplicates_ReturnsFalse()
        {
            // Arrange
            int[] nums = [-1, -2, -3, -4];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_WithZeros_ReturnsTrue()
        {
            // Arrange
            int[] nums = [0, 0];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateBruteForce_DuplicateAtEnd_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicateBruteForce_VariousInputs_ReturnsExpectedResult(int[] nums, bool expected)
        {
            // Act
            bool result = _containsDuplicate.ContainsDuplicateBruteForce(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_WithDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 2, 3, 1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_WithoutDuplicates_ReturnsFalse()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_WithMultipleDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_EmptyArray_ReturnsFalse()
        {
            // Arrange
            int[] nums = [];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_SingleElement_ReturnsFalse()
        {
            // Arrange
            int[] nums = [1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_TwoIdenticalElements_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_WithNegativeNumbers_ReturnsTrue()
        {
            // Arrange
            int[] nums = [-1, -2, -3, -1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_WithNegativeNumbersNoDuplicates_ReturnsFalse()
        {
            // Arrange
            int[] nums = [-1, -2, -3, -4];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_WithZeros_ReturnsTrue()
        {
            // Arrange
            int[] nums = [0, 0];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateOptimized_DuplicateAtEnd_ReturnsTrue()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 1];

            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicateOptimized_VariousInputs_ReturnsExpectedResult(int[] nums, bool expected)
        {
            // Act
            bool result = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void BothMethods_SameInput_ReturnSameResult(int[] nums, bool expected)
        {
            // Act
            bool bruteForceResult = _containsDuplicate.ContainsDuplicateBruteForce(nums);
            bool optimizedResult = _containsDuplicate.ContainsDuplicateOptimized(nums);

            // Assert
            Assert.Equal(expected, bruteForceResult);
            Assert.Equal(expected, optimizedResult);
            Assert.Equal(bruteForceResult, optimizedResult);
        }
    }
}

