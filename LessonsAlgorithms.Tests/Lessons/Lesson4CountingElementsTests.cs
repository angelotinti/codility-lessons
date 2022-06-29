using LessonsAlgorithms;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmExercises.Lessons
{
    public class Lesson4CountingElementsTests
    {
        /**
         * https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
         */
        [Theory]
        [InlineData(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [InlineData(5, new int[] { 1, 3, 5, 4, 2, 3, 1, 4 }, 4)]
        [InlineData(5, new int[] { 3 }, -1)]
        public void FrogRiverOneTest(int X, int[] A, int expectedEarliestTime)
        {
            var earliestTime = new Lesson4CountingElements().FrogRiverOne(X, A);

            Assert.Equal(expectedEarliestTime, earliestTime);
        }

        /**
         * https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
         */
        [Theory]
        [InlineData(new int[] { 4, 1, 3, 2 }, 1)]
        [InlineData(new int[] { 4, 1, 3 }, 0)]
        public void PermCheckTest(int[] A, int expectedPermutation)
        {
            var permutation = new Lesson4CountingElements().PermCheck(A);

            Assert.Equal(expectedPermutation, permutation);
        }

        /**
         * https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
         */
        [Theory]
        [InlineData(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        [InlineData(5, new int[] { 6, 6, 6, 6, 6, 6, 6 }, new int[] { 0, 0, 0, 0, 0 })]
        public void MaxCounterTest(int N, int[] A, int[] expectedResult)
        {
            var result = new Lesson4CountingElements().MaxCounter(N, A);

            Assert.Equal(expectedResult, result);
        }

        /**
         * https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
         */
        [Theory]
        [InlineData(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [InlineData(new int[] { 1, 2, 3 }, 4)]
        [InlineData(new int[] { -3, -1 }, 1)]
        public void MissingIntegerTest(int[] A, int expectedMissingInteger)
        {
            var missingInteger = new Lesson4CountingElements().MissingInteger(A);

            Assert.Equal(expectedMissingInteger, missingInteger);
        }
    }
}
