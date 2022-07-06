using LessonsAlgorithms.Lessons;
using Xunit;

namespace LessonsAlgorithms.Tests.Lessons
{
    public class Lesson10PrimeAndCompositeTests
    {
        [Theory]
        [InlineData(24, 8)]
        [InlineData(48, 10)]
        [InlineData(27043111, 4)]
        [InlineData(16, 5)]
        [InlineData(36, 9)]
        [InlineData(4999696, 45)]
        [InlineData(39992976, 135)]
        public void CountFactorsTests(int N, int expectedFactors)
        {
            var factors = new Lesson10PrimeAndComposite().CountFactos(N);

            Assert.Equal(expectedFactors, factors);
        }
    }
}
