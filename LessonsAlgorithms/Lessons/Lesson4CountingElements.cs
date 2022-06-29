namespace LessonsAlgorithms.Lessons
{
    public class Lesson4CountingElements
    {
        #region FrogRiverOne
        public int FrogRiverOne(int X, int[] A)
        {
            if (A.Length < X)
            {
                return -1;
            }

            var leavesSet = new HashSet<int>();
            var lastLeafSecond = 0;

            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] > X)
                {
                    continue;
                }
                if (!leavesSet.Contains(A[i]))
                {
                    lastLeafSecond = i;
                }
                leavesSet.Add(A[i]);
                if (leavesSet.Count == X)
                {
                    break;
                }
            }

            if (leavesSet.Count < X)
            {
                return -1;
            }

            return lastLeafSecond;
        }
        #endregion

        #region PermCheck
        public int PermCheck(int[] A)
        {
            Array.Sort(A);

            if (A.Length >= 1 && A[0] > 1)
            {
                return 0;
            }

            for (var i = 1; i < A.Length; i++)
            {
                if (A[i - 1] == A[i])
                {
                    return 0;
                }
                if (A[i] > A.Length)
                {
                    return 0;
                }
            }

            return 1;
        }
        #endregion

        #region MaxCounter
        public int[] MaxCounter(int N, int[] A)
        {
            var increase = false;
            var maxCounter = 0;
            var result = new int[N];
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] <= N)
                {
                    increase = true;
                    result[A[i] - 1]++;
                    if (result[A[i] - 1] > maxCounter)
                    {
                        maxCounter = result[A[i] - 1];
                    }
                }
                else if (A[i] == N + 1)
                {
                    if (increase)
                    {
                        Memset(result, maxCounter);
                    }
                }
            }

            return result;
        }

        private void Memset<T>(T[] array, T elem)
        {
            int length = array.Length;
            if (length == 0) return;
            array[0] = elem;
            int count;
            for (count = 1; count <= length / 2; count *= 2)
                Array.Copy(array, 0, array, count, count);
            Array.Copy(array, 0, array, count, length - count);
        }
        #endregion

        #region MissingInteger
        public int MissingInteger(int[] A)
        {
            if (A.Length == 1)
            {
                if (A[0] == 1)
                {
                    return 2;
                }
                if (A[0] <= 0)
                {
                    return 1;
                }
                return A[0] - 1;
            }

            var count = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    var temp = A[i];
                    A[i] = A[count];
                    A[count] = temp;
                    count++;
                }
            }

            var arrayIntegers = new int[A.Length - count];

            for (var i = count; i < A.Length; i++)
            {
                if (A[i] <= arrayIntegers.Length && A[i] > 0)
                {
                    arrayIntegers[A[i] - 1] = A[i];
                }
            }

            for (var i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] == 0)
                {
                    return i + 1;
                }
            }

            return arrayIntegers.Length + 1;
        }
        #endregion
    }
}
