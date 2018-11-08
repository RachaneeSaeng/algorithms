using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class NTUC
    {
        public int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var positiveElemenets = Positive_MergeSort(A, 0, A.Length - 1);

            int checking = 1;
            for (int i = 0; i < positiveElemenets.Length; i++)
            {
                if (positiveElemenets[i] > checking)
                {
                    return checking;
                }

                if (positiveElemenets[i] == checking)
                {
                    checking++;
                }
            }
            return checking;
        }

        private int[] Positive_MergeSort(int[] arr, int startIdx, int endIdx)
        {
            if (startIdx >= endIdx)
            {
                return new int[] { arr[startIdx]};
            }

            var midIdx = (startIdx + endIdx) / 2;
            var leftArray = Positive_MergeSort(arr, startIdx, midIdx);
            var rightArray = Positive_MergeSort(arr, midIdx + 1, endIdx);
            return Merge(leftArray, rightArray);
        }

        private int[] Merge(int[] leftArray, int[] rightArray)
        {
            var result = new List<int>();

            var leftIdx = 0;
            var rightIdx = 0;
            
            while (leftIdx < leftArray.Length && rightIdx < rightArray.Length)
            {
                if (leftArray[leftIdx] <= 0)
                {
                    leftIdx++;
                    continue;
                }
                if (rightArray[rightIdx] <= 0)
                {
                    rightIdx++;
                    continue;
                }

                if (leftArray[leftIdx] <= rightArray[rightIdx])
                {
                    result.Add(leftArray[leftIdx]);
                    leftIdx++;
                }
                else if (leftArray[leftIdx] > rightArray[rightIdx])
                {
                    result.Add(rightArray[rightIdx]);
                    rightIdx++;
                }
            }

            for (int i = leftIdx; i < leftArray.Length; i++)
            {
                result.Add(leftArray[i]);
            }

            for (int i = rightIdx; i < rightArray.Length; i++)
            {
                result.Add(rightArray[i]);
            }
            return result.ToArray();
        }
    }
}
