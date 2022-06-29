using LessonsAlgorithms.Lessons;
using Xunit;

namespace AlgorithmExercises.Lessons
{
    public class Lesson7StacksAndQueuesTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 1 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 0 }, 1)]
        [InlineData(new int[] { 1, 2 }, new int[] { 0, 1 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 0, 0 }, 2)]
        public void FishCountTest(int[] A, int[] B, int expectedCount)
        {
            var count = new Lesson7StacksAndQueues().FishCount(A, B);

            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData("(()(())())", 1)]
        [InlineData("())", 0)]
        [InlineData("", 1)]

        public void NestingTest(string S, int expectedNested)
        {
            var nested = new Lesson7StacksAndQueues().Nesting(S);

            Assert.Equal(expectedNested, nested);
        }

        [Theory]
        [InlineData(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }, 7)]
        public void StoneWallTest(int[] H, int expectedBlocks)
        {
            var blocks = new Lesson7StacksAndQueues().StoneWall(H);

            Assert.Equal(expectedBlocks, blocks);
        }
    }
}
