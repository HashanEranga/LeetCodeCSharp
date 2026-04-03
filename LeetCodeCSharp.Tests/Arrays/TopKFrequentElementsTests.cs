
using Xunit;
using LeetCodeCSharp.Arrays;
using Microsoft.VisualBasic;

namespace LeetCodeCSharp.Tests.Arrays
{
    public class TopKFrequentElementsTests
    {
        private readonly TopKFrequentElements solution;

        public TopKFrequentElementsTests(){
            solution = new TopKFrequentElements();
        }

        [Fact]
        public void TopKFrequentElements_BaseCase_ReturnsIntArray(){
            // Arrange 
            int[] nums = [1,1,1,2,2,3];
            int k = 2;
            int[] expectedResult = [1,2];

            // Act 
            int[] result = solution.TopKFrequent(nums, k);

            // Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void TopKFrequentElements_SingleElement_ReturnsIntArray()
        {
            // Arrange
            int[] nums = [2];
            int k = 3;
            int[] expectedResults = [2];

            // Act
            var results = solution.TopKFrequent(nums, k);

            // Assert
            Assert.Equal(results, expectedResults);
        }

        [Fact]
        public void TopKFrequentElements_MultipleElementsWithSameFrequency_ReturnsIntArray()
        {
            // Arrange 
            int[] nums = [1, 2, 1, 2, 1, 2, 3, 1, 3, 2];
            int k = 2;

            // Act 
            var results = solution.TopKFrequent(nums, k);

            // Assert
            Assert.Contains(1, results);
            Assert.Contains(2, results);

        }

        [Fact]
        public void TopKFrequentElements_IfKisNumOfUniqueElements_ReturnUniqueElements()
        {
            // Arrange 
            int[] nums = [1, 2, 1, 2, 1, 2, 3, 1, 3, 2];
            int k = 3;
            int[] expectedResults = [1, 2, 3];

            // Act 
            var results = solution.TopKFrequent(nums, k);

            // Arrange 
            Assert.Equal(expectedResults, results);
        }
    }
}