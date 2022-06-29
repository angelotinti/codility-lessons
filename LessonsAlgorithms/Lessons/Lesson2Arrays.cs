namespace LessonsAlgorithms.Lessons
{
    public class Lesson2Arrays
    {
        #region CyclicRotation
        public int[] CyclicRotation(int[] A, int K)
        {
            if (K == 0 || A.Length == 0)
            {
                return A;
            }

            if (A.Length == 1)
            {
                return A;
            }

            var mod = K % A.Length;

            if (mod == 0)
            {
                return A;
            }

            var result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                var position = i + mod;
                if (position >= A.Length)
                {
                    position -= A.Length;
                }
                result[position] = A[i];
            }

            return result;
        }
        #endregion

        #region OddOccurrencesInArray
        public int OddOccurrencesInArray(int[] A)
        {
            if (A.Length == 1)
            {
                return A[0];
            }

            var set = new HashSet<int>();

            for (var i = 0; i < A.Length; i++)
            {
                if (set.Contains(A[i]))
                {
                    set.Remove(A[i]);
                }
                else
                {
                    set.Add(A[i]);
                }
            }

            var oddNumber = set.ToList().ElementAt(0);

            return oddNumber;
        }
        #endregion
    }
}
