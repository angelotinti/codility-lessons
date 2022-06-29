namespace LessonsAlgorithms.Lessons
{
    public class Lesson8Leader
    {
        #region Dominator
        public int Dominator(int[] A)
        {
            if (A.Length == 0)
            {
                return -1;
            }

            var dominators = new Dictionary<int, List<int>>();

            for (var i = 0; i < A.Length; i++)
            {
                if (!dominators.ContainsKey(A[i]))
                {
                    dominators.Add(A[i], new List<int>());
                }
                dominators[A[i]].Add(i);
            }

            var orderedDominators = dominators.OrderByDescending(x => x.Value.Count).ToList();

            return orderedDominators.First().Value.Count > A.Length / 2
                ? orderedDominators.First().Value.First()
                : -1;
        }
        #endregion

        #region EquiLeader
        public int EquiLeader(int[] A)
        {
            if (A.Length == 0 || A.Length == 1)
            {
                return 0;
            }

            var equiLeadersCount = 0;

            var wholeArrayCount = new Dictionary<int, int>();

            for (var i = 0; i < A.Length; i++)
            {
                if (!wholeArrayCount.ContainsKey(A[i]))
                {
                    wholeArrayCount.Add(A[i], 0);
                }
                wholeArrayCount[A[i]]++;
            }

            if (wholeArrayCount.Count == A.Length)
            {
                return 0;
            }

            var firstSequenceCount = new Dictionary<int, int>();

            for (var i = 0; i < A.Length - 1; i++)
            {
                if (!firstSequenceCount.ContainsKey(A[i]))
                {
                    firstSequenceCount.Add(A[i], 0);
                }
                firstSequenceCount[A[i]]++;

                wholeArrayCount[A[i]]--;
                if (wholeArrayCount[A[i]] == 0)
                {
                    wholeArrayCount.Remove(A[i]);
                }

                var firstSequenceLeader = 0;
                var firstLeaderFound = false;
                if (firstSequenceCount.Count == 1)
                {
                    firstSequenceLeader = firstSequenceCount.First().Key;
                    firstLeaderFound = true;
                }
                else if (firstSequenceCount.ElementAt(0).Value != firstSequenceCount.ElementAt(1).Value
                    && firstSequenceCount.ElementAt(0).Value > (double)(i + 1) / 2)
                {
                    firstSequenceLeader = firstSequenceCount.ElementAt(0).Key;
                    firstLeaderFound = true;
                }

                var secondSequenceLeader = 0;
                var secondLeaderFound = false;
                if (wholeArrayCount.Count == 1)
                {
                    secondSequenceLeader = wholeArrayCount.First().Key;
                    secondLeaderFound = true;
                }
                else if (wholeArrayCount.ElementAt(0).Value != wholeArrayCount.ElementAt(1).Value
                    && wholeArrayCount.ElementAt(0).Value > (double)(A.Length - i - 1) / 2)
                {
                    secondSequenceLeader = wholeArrayCount.ElementAt(0).Key;
                    secondLeaderFound = true;
                }

                if (firstLeaderFound && secondLeaderFound && secondSequenceLeader == firstSequenceLeader)
                {
                    equiLeadersCount++;
                }
            }

            return equiLeadersCount;
        }
        #endregion
    }
}
