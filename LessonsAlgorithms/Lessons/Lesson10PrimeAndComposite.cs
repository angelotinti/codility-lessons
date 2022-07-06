namespace LessonsAlgorithms.Lessons
{
    public class Lesson10PrimeAndComposite
    {
        public int CountFactos(int N)
        {
            var factors = 0;
            var sqrtRoot = Math.Sqrt(N);
            for (int i = 1; i < sqrtRoot; i++)
            {
                if (N % i == 0)
                {
                    factors++;
                }
            }
            factors = factors * 2;
            if (sqrtRoot == Math.Truncate(sqrtRoot))
            {
                factors++;
            }
            return factors;
        }
    }
}
