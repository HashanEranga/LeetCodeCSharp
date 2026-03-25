using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LeetCodeCSharp.Arrays;

namespace LeetCodeCSharp.Tests.Arrays
{
    public class ValidAnagramTests
    {
        private readonly ValidAnagram _validAnagram;

        public ValidAnagramTests()
        {
            _validAnagram = new ValidAnagram();
        }

        #region IsAnagramBruteForce Tests

        [Fact]
        public void IsAnagramBruteForce_ValidAnagram_ReturnsTrue()
        {
            // Arrange
            string s = "anagram";
            string t = "nagaram";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramBruteForce_NotAnagram_ReturnsFalse()
        {
            // Arrange
            string s = "rat";
            string t = "car";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramBruteForce_DifferentLengths_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "abcd";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramBruteForce_EmptyStrings_ReturnsTrue()
        {
            // Arrange
            string s = "";
            string t = "";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramBruteForce_SingleCharacterMatch_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "a";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramBruteForce_SingleCharacterNoMatch_ReturnsFalse()
        {
            // Arrange
            string s = "a";
            string t = "b";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramBruteForce_RepeatingCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "aabbcc";
            string t = "abcabc";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramBruteForce_DifferentFrequencies_ReturnsFalse()
        {
            // Arrange
            string s = "aab";
            string t = "abb";

            // Act
            bool result = _validAnagram.IsAnagramBruteForce(s, t);

            // Assert
            Assert.False(result);
        }

        #endregion

        #region IsAnagramOptimized Tests

        [Fact]
        public void IsAnagramOptimized_ValidAnagram_ReturnsTrue()
        {
            // Arrange
            string s = "anagram";
            string t = "nagaram";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramOptimized_NotAnagram_ReturnsFalse()
        {
            // Arrange
            string s = "rat";
            string t = "car";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramOptimized_DifferentLengths_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "abcd";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramOptimized_EmptyStrings_ReturnsTrue()
        {
            // Arrange
            string s = "";
            string t = "";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramOptimized_SingleCharacterMatch_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "a";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramOptimized_SingleCharacterNoMatch_ReturnsFalse()
        {
            // Arrange
            string s = "a";
            string t = "b";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramOptimized_RepeatingCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "aabbcc";
            string t = "abcabc";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramOptimized_DifferentFrequencies_ReturnsFalse()
        {
            // Arrange
            string s = "aab";
            string t = "abb";

            // Act
            bool result = _validAnagram.IsAnagramOptimized(s, t);

            // Assert
            Assert.False(result);
        }

        #endregion

        #region IsAnagramSortingReducedSpaceComplexity Tests

        [Fact]
        public void IsAnagramSorting_ValidAnagram_ReturnsTrue()
        {
            // Arrange
            string s = "anagram";
            string t = "nagaram";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramSorting_NotAnagram_ReturnsFalse()
        {
            // Arrange
            string s = "rat";
            string t = "car";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramSorting_DifferentLengths_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "abcd";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramSorting_EmptyStrings_ReturnsTrue()
        {
            // Arrange
            string s = "";
            string t = "";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramSorting_SingleCharacterMatch_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "a";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramSorting_SingleCharacterNoMatch_ReturnsFalse()
        {
            // Arrange
            string s = "a";
            string t = "b";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsAnagramSorting_RepeatingCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "aabbcc";
            string t = "abcabc";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAnagramSorting_DifferentFrequencies_ReturnsFalse()
        {
            // Arrange
            string s = "aab";
            string t = "abb";

            // Act
            bool result = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.False(result);
        }

        #endregion

        #region Theory Tests - All Methods

        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("", "", true)]
        [InlineData("a", "a", true)]
        [InlineData("a", "b", false)]
        [InlineData("listen", "silent", true)]
        [InlineData("hello", "world", false)]
        public void AllMethods_VariousInputs_ReturnExpectedResult(string s, string t, bool expected)
        {
            // Act
            bool bruteForceResult = _validAnagram.IsAnagramBruteForce(s, t);
            bool optimizedResult = _validAnagram.IsAnagramOptimized(s, t);
            bool sortingResult = _validAnagram.IsAnagramSortingReducedSpaceComplexity(s, t);

            // Assert
            Assert.Equal(expected, bruteForceResult);
            Assert.Equal(expected, optimizedResult);
            Assert.Equal(expected, sortingResult);
        }

        #endregion
    }
}
