using AutoFixture;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmDemo.Tests
{
    internal class TestDataForSortingTests : IEnumerable<object[]>
    {
        private static Fixture _fixture =  new Fixture();

        public IEnumerator<object[]> GetEnumerator()
        {
            var iterationsCount = Random.Shared.Next(5, 200);
            for (int i = 0; i < iterationsCount; i++)
            {
                yield return new object[]
                {
                    GenerateNewPair().Item1,
                    GenerateNewPair().Item2
                };
            }
        }

        private (List<int>, List<int>) GenerateNewPair()
        {
            var originalArray = _fixture.CreateMany<int>(Random.Shared.Next(50, 1000)).ToList();
            var sortedArray = new List<int>(originalArray);

            sortedArray.Sort();

            return (originalArray, sortedArray);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
