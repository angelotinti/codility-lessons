namespace LessonsAlgorithms.Lessons
{
    public class Lesson1Iterations
    {
        #region BinaryGap
        public int BinaryGap(int N)
        {
            var binary = Convert.ToString(N, 2);
            var result = 0;
            var gapCount = 0;
            var inGap = false;
            foreach (var b in binary)
            {
                if (b == '1' && inGap)
                {
                    if (gapCount > result)
                    {
                        result = gapCount;
                    }
                    gapCount = 0;
                    inGap = false;
                }
                if (b == '1')
                {
                    inGap = true;
                    continue;
                }
                if (b == '0' && inGap)
                {
                    gapCount++;
                }
            }
            return result;
        }
        #endregion
    }
}
