using AlogithmDemo;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmDemo.Tests
{
    public class SelectionSortTests
    {
        [Fact]
        public void NullInput_ShouldReturnNull()
        {
            List<int> originalList = null;

            var actualList = originalList.SelectionSort();

            actualList.Should().BeNull();
        }

        [Fact]
        public void EmptyInput_ShouldReturnEmptyList()
        {
            List<int> originalList = new List<int>();

            var actualList = originalList.SelectionSort();

            actualList.Should().NotBeNull();
            actualList.Should().BeEmpty();
        }

        [Theory]
        [ClassData(typeof(TestDataForSortingTests))]
        public void ArrayInput_ShouldReturnSortedArray(List<int> originalList, List<int> expectedSortedList)
        {
            var actualList = originalList.SelectionSort();

            actualList.Should().NotBeNull();
            actualList.Should().BeEquivalentTo(expectedSortedList);
        }

        [Fact]
        public void Test()
        {
            List<int> input = new List<int> { 9, 5, 39, -9, -5, 0 };
            List<int> expectedSortedList = new List<int> { -9, -5, 0, 5, 9, 39 };

            var actuaSortedList =  input.SelectionSort();

            actuaSortedList.Should().NotBeNull();
            actuaSortedList.Should().BeEquivalentTo(expectedSortedList);
        }
    }
}