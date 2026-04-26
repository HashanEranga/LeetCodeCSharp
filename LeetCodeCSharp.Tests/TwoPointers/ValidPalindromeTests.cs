using LeetCodeCSharp.TwoPointers;
using System;

namespace LeetCodeCSharp.Tests.TwoPointers
{
    public class ValidPalindromeTests
    {
        private readonly ValidPalindrome validPalindromeSol;

        public ValidPalindromeTests()
        {
            validPalindromeSol = new ValidPalindrome();
        }

        [Theory]
        [InlineData("race a car", false)]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData(" ", true)]
        public void IsValidPalindrome_BaseCaseExample_ReturnTrue(string input, bool expectedResult)
        {
            // Act 
            var result = validPalindromeSol.IsPalindrome(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }   
    
}

