namespace LessonsAlgorithms.Lessons
{
    public class Lesson6Sorting
    {
        #region Distinct
        public int Distinct(int[] A)
        {
            var set = new HashSet<int>();

            for (var i = 0; i < A.Length; i++)
            {
                set.Add(A[i]);
            }

            return set.Count;
        }
        #endregion

        #region MaxProductOfThree
        public int MaxProductOfThree(int[] A)
        {
            if (A.Length == 3)
            {
                return A[0] * A[1] * A[2];
            }

            var segregateIndex = SegregateInts(A);

            if (segregateIndex == A.Length || segregateIndex == 0 || segregateIndex == 1)
            {
                var maxInts = new int[3];
                maxInts[0] = int.MinValue;
                maxInts[1] = int.MinValue;
                maxInts[2] = int.MinValue;

                for (int i = 0; i < A.Length; i++)
                {
                    AddMaxInt(maxInts, A[i]);
                }

                return maxInts[0] * maxInts[1] * maxInts[2];
            }

            var maxPositives = new int[3];
            maxPositives[0] = int.MinValue;
            maxPositives[1] = int.MinValue;
            maxPositives[2] = int.MinValue;
            var maxNegatives = new int[3];
            maxNegatives[0] = int.MinValue;
            maxNegatives[1] = int.MinValue;
            maxNegatives[2] = int.MinValue;
            var minNegatives = new int[3];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    AddMaxInt(maxNegatives, A[i]);
                    AddMinInt(minNegatives, A[i]);
                }
                else
                {
                    AddMaxInt(maxPositives, A[i]);
                }
            }

            var max1 = maxPositives[0] * maxPositives[1] * maxPositives[2];
            var max2 = minNegatives[0] * minNegatives[1] * maxPositives[2];
            var max3 = maxNegatives[2] * maxNegatives[1] * maxPositives[0];

            return Math.Max(max1, Math.Max(max2, max3));
        }

        private void AddMaxInt(int[] array, int maxInt)
        {
            if (maxInt > array[2])
            {
                array[0] = array[1];
                array[1] = array[2];
                array[2] = maxInt;
            }
            else if (maxInt > array[1])
            {
                array[0] = array[1];
                array[1] = maxInt;
            }
            else if (maxInt > array[0])
            {
                array[0] = maxInt;
            }
        }

        private void AddMinInt(int[] array, int minInt)
        {
            if (minInt < array[0])
            {
                array[2] = array[1];
                array[1] = array[0];
                array[0] = minInt;
            }
            else if (minInt < array[1])
            {
                array[2] = array[1];
                array[1] = minInt;
            }
            else if (minInt < array[2])
            {
                array[2] = minInt;
            }
        }
        #endregion

        #region Triangle
        public int Triangle(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }

            var segregateIndex = SegregateInts(A);

            if (segregateIndex == A.Length)
            {
                return 0;
            }

            var temp = 0;
            for (int write = 0; write < A.Length; write++)
            {
                for (int sort = 0; sort < A.Length - 1; sort++)
                {
                    if (A[sort] > A[sort + 1])
                    {
                        temp = A[sort + 1];
                        A[sort + 1] = A[sort];
                        A[sort] = temp;
                    }
                }
                if (write >= 2)
                {
                    if ((long)A[write - 2] + A[write - 1] > A[write])
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
        #endregion

        private int SegregateInts(int[] array)
        {
            var j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    var temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    j++;
                }
            }
            return j;
        }
    }
}
