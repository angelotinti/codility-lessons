using LessonsAlgorithms;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgorithmExercises.Lessons
{
    public class Lesson2ArraysTests
    {
        /**
         * Problem description
         * https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
         */
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 0, 0, 0 }, 1, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 1000 }, 5, new int[] { 1000 })]
        [InlineData(new int[] { 1, 3, 5, 7, 9, 11 }, 7, new int[] { 11, 1, 3, 5, 7, 9 })]
        [InlineData(new int[] { 1, 2, 3 }, 9, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, 0, new int[] { })]
        public void CyclicRotationTest(int[] A, int K, int[] expectedRotatedArray)
        {
            var rotatedArray = new Lesson2Arrays().CyclicRotation(A, K);

            Assert.Equal(expectedRotatedArray, rotatedArray);
        }

        /**
         * Problem description
         * https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
         */
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void OddOccurrencesInArrayTest(int[] A, int expectedUnpairedElement)
        {
            var unpairedElement = new Lesson2Arrays().OddOccurrencesInArray(A);

            Assert.Equal(expectedUnpairedElement, unpairedElement);
        }
    }
}
