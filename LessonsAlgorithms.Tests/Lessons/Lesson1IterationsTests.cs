using LessonsAlgorithms.Lessons;
using Xunit;

namespace LessonsAlgorithms.Tests.Lessons
{
    public class Lesson1IterationsTests
    {
        /**
         * Problem description
         * https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
         */
        [Theory]
        [InlineData(1041, 5)]
        [InlineData(20, 1)]
        [InlineData(9, 2)]
        [InlineData(32, 0)]
        [InlineData(15, 0)]
        public void BinaryGapTest(int N, int expectedGap)
        {
            var gap = new Lesson1Iterations().BinaryGap(N);

            Assert.Equal(expectedGap, gap);
        }
    }
}
