namespace LessonsAlgorithms.Lessons
{
    public class Lesson3TimeComplexity
    {
        #region FrogJmp
        public int FrogJmp(int X, int Y, int D)
        {
            var distance = Y - X;
            var jumps = Math.Ceiling((double)distance / D);
            return (int)jumps;
        }
        #endregion

        #region PermMissingElement
        public int PermMissingElement(int[] A)
        {
            var sumArray = 0;
            var sumNumbers = 0;
            var sumAux = 1;

            for (var i = 0; i < A.Length; i++)
            {
                sumArray += A[i];
                sumNumbers += sumAux;
                sumAux++;
            }

            sumNumbers += sumAux;

            return sumNumbers - sumArray;
        }
        #endregion

        #region TapeEquilibrium
        public int TapeEquilibrium(int[] A)
        {
            if (A.Length == 2)
            {
                return Math.Abs(A[0] - A[1]);
            }

            var total = 0;
            for (var i = 0; i < A.Length; i++)
            {
                total += A[i];
            }

            var minimalDiff = int.MaxValue;
            var sumFirstPart = 0;
            for (var i = 0; i < A.Length - 1; i++)
            {
                sumFirstPart += A[i];
                var diff = total - sumFirstPart;
                diff = Math.Abs(sumFirstPart - diff);
                if (diff < minimalDiff)
                {
                    minimalDiff = diff;
                }
            }

            return minimalDiff;
        }
        #endregion
    }
}
