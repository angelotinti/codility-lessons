using LessonsAlgorithms.Lessons;
using System;
using Xunit;

namespace LessonsAlgorithms.Tests.Lessons
{
    public class Lesson9MaximumSliceProblemTests
    {
        [Theory]
        [InlineData(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }, 356)]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, 0)]
        public void MaxProfitTest(int[] A, int expectedMaxProfit)
        {
            var maxProfit = new Lesson9MaximumSliceProblem().MaxProfit(A);

            Assert.Equal(expectedMaxProfit, maxProfit);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, -6, 4, 0 }, 5)]
        [InlineData(new int[] { 3, 2, -6, 4, 0, 1, 3 }, 8)]
        [InlineData(new int[] { -2, 3 }, 3)]
        [InlineData(new int[] { -2, -2 }, -2)]
        [InlineData(new int[] { 1, -2, 3 }, 3)]
        public void MaxSliceSumTest(int[] A, int expectedMaxSliceSum)
        {
            var maxSliceSum = new Lesson9MaximumSliceProblem().MaxSliceSum(A);

            Assert.Equal(expectedMaxSliceSum, maxSliceSum);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 7)]
        [InlineData(new int[] { 5, 8, 9 }, 0)]
        [InlineData(new int[] { 5, 17, 0, 3 }, 17)]
        public void MaxDoubleSliceSumTest(int[] A, int expectedMaximalSum)
        {
            var maximalSum = new Lesson9MaximumSliceProblem().MaxDoubleSliceSum(A);

            Assert.Equal(expectedMaximalSum, maximalSum);
        }
    }
}
