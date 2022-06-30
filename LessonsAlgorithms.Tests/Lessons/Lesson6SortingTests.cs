using LessonsAlgorithms.Lessons;
using System;
using Xunit;

namespace LessonsAlgorithms.Tests.Lessons
{
    public class Lesson6SortingTests
    {
        /**
         * https://app.codility.com/programmers/lessons/6-sorting/distinct/
         */
        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
        public void DistinctTest(int[] A, int expectedDistinctNumbers)
        {
            var distinctNumbers = new Lesson6Sorting().Distinct(A);

            Assert.Equal(expectedDistinctNumbers, distinctNumbers);
        }

        /**
         * https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/
         */
        [Theory]
        [InlineData(new int[] { -3, 1, 2, -2, 5, 6 }, 60)]
        public void MaxProductOfThreeTest(int[] A, int expectedMaxProduct)
        {
            var maxProduct = new Lesson6Sorting().MaxProductOfThree(A);

            Assert.Equal(expectedMaxProduct, maxProduct);
        }

        /**
         * https://app.codility.com/programmers/lessons/6-sorting/triangle/
         */
        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [InlineData(new int[] { 10, 50, 5, 1 }, 0)]
        public void TriangleTest(int[] A, int expectedTriangular)
        {
            var triangular = new Lesson6Sorting().Triangle(A);

            Assert.Equal(expectedTriangular, triangular);
        }

        /**
         * https://app.codility.com/programmers/lessons/6-sorting/number_of_disc_intersections/
         */
        [Theory]
        [InlineData(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        [InlineData(new int[] { 1, 1, 1 }, 3)]
        [InlineData(new int[] { 1, 0, 1, 0, 1 }, 6)]
        [InlineData(new int[] { 0, 1, 0, 1, 0 }, 5)]
        [InlineData(new int[] { 3, 3, 3, 5, 1, 2 }, 15)]
        public void NumberOfDiscIntersectionTest(int[] A, int expectedIntersections)
        {
            var intersections = new Lesson6Sorting().NumberOfDiscIntersections(A);

            Assert.Equal(expectedIntersections, intersections);
        }
    }
}
