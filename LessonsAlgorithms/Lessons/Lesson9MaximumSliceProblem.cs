using System.Collections.Generic;

namespace LessonsAlgorithms.Lessons
{
    public class Lesson9MaximumSliceProblem
    {
        public int MaxProfit(int[] A)
        {
            var maxProfit = 0;

            var maxValue = int.MinValue;
            var minValue = int.MaxValue;
            var calcProfit = false;

            for (int i = 0; i < A.Length; i++)
            {
                if (i < A.Length - 1 && A[i] < minValue)
                {
                    minValue = A[i];
                    maxValue = int.MinValue;
                    calcProfit = false;
                }
                if (i > 0)
                {
                    if (A[i] > maxValue)
                    {
                        maxValue = A[i];
                        calcProfit = true;
                    }
                    if (minValue > maxValue)
                    {
                        maxValue = int.MinValue;
                        minValue = int.MaxValue;
                        calcProfit = false;
                        continue;
                    }
                    if (calcProfit)
                    {
                        var profit = maxValue - minValue;
                        if (profit > maxProfit)
                        {
                            maxProfit = profit;
                        }
                    }
                }
            }

            return maxProfit;
        }

        public int MaxSliceSum(int[] A)
        {
            if (A.Length == 1)
            {
                return A[0];
            }

            var maxSliceSum = int.MinValue;
            var sliceSum = int.MinValue;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > sliceSum + A[i])
                {
                    sliceSum = A[i];
                    if (sliceSum > maxSliceSum)
                    {
                        maxSliceSum = sliceSum;
                    }
                    continue;
                }
                if (sliceSum + A[i] > sliceSum)
                {
                    if (sliceSum == int.MinValue)
                    {
                        sliceSum = A[i];
                    }
                    else
                    {
                        sliceSum += A[i];
                    }
                    if (sliceSum > maxSliceSum)
                    {
                        maxSliceSum = sliceSum;
                    }
                    continue;
                }
                if (i < A.Length - 1)
                {
                    if (sliceSum + A[i] + A[i + 1] > sliceSum)
                    {
                        sliceSum += A[i];
                        continue;
                    }
                    else
                    {
                        sliceSum = int.MinValue;
                    }
                }
            }

            return maxSliceSum;
        }
    }
}
