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

            var minValue = 1000001 * -1;

            var maxSliceSum = minValue;
            var sliceSum = minValue;

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
                else if (sliceSum + A[i] > sliceSum)
                {
                    if (sliceSum == minValue)
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
                else if (sliceSum + A[i] > 0)
                {
                    sliceSum += A[i];
                    if (sliceSum > maxSliceSum)
                    {
                        maxSliceSum = sliceSum;
                    }
                    continue;
                }
                sliceSum = minValue;
            }

            return maxSliceSum;
        }
    }
}
