using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class CrossOver
    {
        #region Sort by 1's in binary

        public struct Element
        {
            public int Value { get; set; }
            public int NumberOfOne { get; set; }
        }

        public static int[] Rearrange(int[] elements)
        {
            Element[] elms = elements.Select(e => new Element
            {
                Value = e,
                NumberOfOne = Convert.ToString(e, 2).Replace("0", "").Length
            })
            .ToArray();

            QuickSort(elms, 0, elements.Length - 1);

            return elms.Select(e => e.Value).ToArray();
        }

        /// <summary>
        /// O = N * Log N
        /// The best performance is N
        /// set pivot at an index and make everything in left hand side less than it and right hand side more than it
        /// do recursively
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void QuickSort(Element[] arr, int minIdx, int maxIdx)
        {
            // For Recusrion  
            if (minIdx < maxIdx)
            {
                int pivotIndex = Partition(arr, minIdx, maxIdx);

                if (pivotIndex > 1)
                    QuickSort(arr, minIdx, pivotIndex - 1);

                if (pivotIndex + 1 < maxIdx)
                    QuickSort(arr, pivotIndex + 1, maxIdx);
            }
        }

        private static int Partition(Element[] arr, int minIdx, int maxIdx)
        {
            int pivotNumberOfOne = arr[minIdx].NumberOfOne;
            int pivotValue = arr[minIdx].Value;
            while (true)
            {
                while (arr[minIdx].NumberOfOne < pivotNumberOfOne ||
                       (arr[minIdx].NumberOfOne == pivotNumberOfOne && arr[minIdx].Value < pivotValue)) //Stop when found a value is not in the right place
                    minIdx++;

                while (pivotNumberOfOne < arr[maxIdx].NumberOfOne ||
                       (arr[maxIdx].NumberOfOne == pivotNumberOfOne && pivotValue < arr[maxIdx].Value)) //Stop when found a value is not in the right place
                    maxIdx--;

                if (minIdx < maxIdx) //some value stop counter in the upper conditions which make minIdx < maxIdx
                {
                    if (arr[minIdx].Equals(arr[maxIdx])) //if both values are equal move them to pivot position                    
                        maxIdx--;

                    //swap
                    Element temp = arr[maxIdx];
                    arr[maxIdx] = arr[minIdx];
                    arr[minIdx] = temp;
                }
                else
                {
                    return maxIdx;
                }
            }
        }
        #endregion

        #region Balance expression
        public static int[] FindUnbalanceCharaters(string[] expressions, int[] maxReplacements)
        {
            int[] result = new int[expressions.Length];

            for (int i = 0;  i < expressions.Length;  i++)
            {
                var str = expressions[i];

                if (string.IsNullOrEmpty(str))
                    continue;

                var expressionStack = new Stack<char>();

                foreach (char c in str.ToCharArray())
                {
                    if (expressionStack.Count == 0)
                    {
                        expressionStack.Push(c);
                    }
                    else
                    {
                        if (expressionStack.Peek() == '<' && c == '>')
                            expressionStack.Pop();
                        else
                            expressionStack.Push(c);
                    }
                }

                var maxReplacement = maxReplacements.Length > i ? maxReplacements[i] : 0;

                result[i] = (expressionStack.Count <= maxReplacement ? 1 : 0);
            }
            return result;
        }

        #endregion
    }
}
