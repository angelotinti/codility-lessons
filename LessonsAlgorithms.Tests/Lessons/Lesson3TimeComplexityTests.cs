using LessonsAlgorithms;
using System;
using Xunit;

namespace AlgorithmExercises.Lessons
{
    public class Lesson3TimeComplexityTests
    {
        /**
         * https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
         */
        [Theory]
        [InlineData(10, 85, 30, 3)]
        [InlineData(3, 999111321, 7, 142730189)]
        public void FrogJmpTest(int X, int Y, int D, int expectedJumps)
        {
            var jumps = new Lesson3TimeComplexity().FrogJmp(X, Y, D);

            Assert.Equal(expectedJumps, jumps);
        }

        /**
         * https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
         */
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
        public void PermMissingElemTest(int[] A, int expectedMissingElement)
        {
            var missingElement = new Lesson3TimeComplexity().PermMissingElement(A);

            Assert.Equal(expectedMissingElement, missingElement);
        }

        /**
         * https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
         */
        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4, 3 }, 1)]
        public void TapeEquilibriumTest(int[] A, int expectedMinimalDiff)
        {
            var minimalDiff = new Lesson3TimeComplexity().TapeEquilibrium(A);

            Assert.Equal(expectedMinimalDiff, minimalDiff);
        }
    }
}
