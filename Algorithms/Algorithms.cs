using System;
using System.Collections.Generic;

namespace Algorithms
{
    public enum SortDirection { Ascending, Descending };

    public class Point
    {
        public int X { get; set; }
        public int y { get; set; }
    }

    public class Algorithms
    {
        public int x;

        public void SetValue()
        {
            x = 10;
        }

        public void SetValue(int y)
        {
            y = 99;
        }

        int move = 1;
        public int Factorial(int n) //O = n
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public int Fibonacci(int n) //O = n
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        public char Random()
        {
            char[] charArr = new char[] { 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'D' };
            Random rnd = new Random();
            return charArr[rnd.Next(10)];
        }

        public char Random2()
        {
            Random rnd = new Random();
            int ranNumber = rnd.Next(100);

            if (ranNumber < 15)       //  15%
                return 'A';
            else if (ranNumber < 35)  //  15% + 20%
                return 'B';
            else if (ranNumber < 60)  //  15% + 20% + 25%
                return 'C';
            else
                return 'D';
        }

        public int FindMin(int[] arr, int startIdx, int toIdx)
        {
            if (startIdx == toIdx)
                return arr[startIdx];
            else
            {
                int min = FindMin(arr, startIdx + 1, toIdx);
                if (arr[startIdx] < min)
                    return arr[startIdx];
                else
                    return min;
            }
        }

        public int IndexOfWord(string str, string word)
        {
            if (word.Length > str.Length)
                return -1;
            if (string.Compare(str.Substring(0, word.Length), word) == 0)
                return 0;
            else
            {
                int foundIdx = IndexOfWord(str.Substring(1), word);
                return (foundIdx == -1 ? -1 : foundIdx + 1);
            }
        }

        public int[] Knapsack(int[] arr, int startIdx, int totalWeight)
        {
            if (totalWeight < 0 || startIdx >= arr.Length)
                return new int[0];

            for (int i = startIdx; i < arr.Length; i++)
            {
                if (arr[i] == totalWeight)
                    return new int[] { arr[i] };
                else
                {
                    int[] comWeight = Knapsack(arr, i + 1, totalWeight - arr[i]);
                    if (comWeight.Length > 0)
                    {
                        int[] ans = new int[comWeight.Length + 1];
                        ans[0] = arr[i];
                        for (int j = 0; j < comWeight.Length; j++)
                        {
                            ans[j + 1] = comWeight[j];
                        }
                        return ans;
                    }
                }
            }
            return new int[0];
        }

        public List<int> GetTwoBig(int[] arr) //O=n
        {
            int? fb = null;
            int? sb = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (fb == null)
                    fb = arr[i];
                else if (fb < arr[i])
                {
                    sb = fb;
                    fb = arr[i];
                }
                else if (sb == null || sb < arr[i])
                {
                    sb = arr[i];
                }
            }

            List<int> ret = new List<int>();
            if (fb.HasValue)
                ret.Add(fb.GetValueOrDefault());
            if (sb.HasValue)
                ret.Add(sb.GetValueOrDefault());

            return ret;
        }

        public void SelectionSort(int[] a) //O = n^2
        {
            //int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < a.Length; j++) // get index of smallest value in remain list
                {
                    //count++;
                    if (a[minIdx] > a[j]) minIdx = j;
                }
                if (minIdx != i)
                {
                    int temp = a[minIdx];
                    a[minIdx] = a[i];
                    a[i] = temp; //swap smallest value to i
                }
            }
        }

        public void InsertionSort(int[] arr) //O = n^2 , 0 = n
        {
            //better performance if some element sorted
            //int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;
                while (j >= 1 && temp < arr[j - 1])
                {
                    //count++;
                    arr[j] = arr[j - 1];
                    j--;
                }
                if (j != i)
                    arr[j] = temp;
                //else
                //    count++;
            }

        }

        public void ShellSort(int[] arr) //O = n^3/2 , 0 = n
        {
            int h = 1;
            while (h <= arr.Length / 3)
                h = h * 3 + 1;
            while (h > 0)
            {
                for (int i = h; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j = i;
                    while (j >= h && temp < arr[j - h])
                    {
                        //count++;
                        arr[j] = arr[j - h];
                        j -= h;
                    }
                    if (j != i)
                        arr[j] = temp;
                }
                h = (h - 1) / 3;
            }
        }

        public void BubleSort(int[] arr) //O = n^2
        {
            bool isSorted = false;
            int count = 0;
            //sorting an array
            for (int i = 0; (i < arr.Length - 1) && !isSorted; i++) //leave the last member
            {
                isSorted = true;
                for (int j = 0; j < (arr.Length - 1 - i); j++)
                {
                    count++;
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        isSorted = false;
                    }
                }
            }

        }

        public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);
                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public void Sort(int[] arr, SortDirection dir)
        {
            //better performance if some element sorted
            //int count = 0;
            int curIdx = 1;
            while (curIdx < arr.Length)
            {
                //count++;
                int curVal = arr[curIdx];
                if (curIdx - 1 >= 0)
                {
                    int prevVal = arr[curIdx - 1];
                    if (dir == SortDirection.Ascending && curVal < prevVal)
                    {
                        arr[curIdx - 1] = curVal;
                        arr[curIdx] = prevVal;
                        curIdx--;
                    }
                    else if (dir == SortDirection.Descending && curVal > prevVal)
                    {
                        arr[curIdx - 1] = curVal;
                        arr[curIdx] = prevVal;
                        curIdx--;
                    }
                    else
                    {
                        curIdx++;
                    }
                }
                else
                {
                    curIdx++;
                }
            };

        }

        /// <summary>
        /// O = N^2
        /// The best performance is N
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void QuickSort(int[] arr, int minIdx, int maxIdx)
        {
            // For Recusrion  
            if (minIdx < maxIdx)
            {
                int pivot = Partition(arr, minIdx, maxIdx);

                if (pivot > 1)
                    QuickSort(arr, minIdx, pivot - 1);

                if (pivot + 1 < maxIdx)
                    QuickSort(arr, pivot + 1, maxIdx);
            }
        }


        private int Partition(int[] numbers, int minIdx, int maxIdx)
        {
            int pivot = numbers[minIdx];
            while (true)
            {
                while (numbers[minIdx] < pivot) //Stop when found a value is not in the right place
                    minIdx++;

                while (pivot < numbers[maxIdx]) //Stop when found a value is not in the right place
                    maxIdx--;

                if (minIdx < maxIdx) //some value stop counter which make minIdx < maxIdx
                {
                    //swap
                    int temp = numbers[maxIdx];
                    numbers[maxIdx] = numbers[minIdx];
                    numbers[minIdx] = temp;
                }
                else
                {
                    return maxIdx;
                }
            }
        }

        public bool CheckDuplicate1(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Add(arr[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckDuplicate2(int[] arr)
        {
            //better performance
            List<int> set = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i]))
                    return false;
                else
                    set.Add(arr[i]);
            }
            return true;
        }

        public void PrintPair(int[] arr, int n)
        {
            if (arr.Length <= 1 || n < (arr[0] + arr[1]) || n > (arr[arr.Length - 2] + arr[arr.Length - 1]))
                return;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int comNumber = n - arr[i];
                if (comNumber < arr[i + 1])
                    break;
                if (Array.IndexOf(arr, comNumber, i + 1) != -1)
                    Console.WriteLine(arr[i] + "  " + comNumber);

            }
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false; //Even number greater than 2 is not prime

            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public double ClockAngle(int h, int m)
        {
            double hAngle = ((h % 12) + (Convert.ToDouble(m) / 60)) * 30; // 1 hour = 360/12 = 30
            double mAngle = m * 6; // 1 minutes = 360/60 = 6
            double angle = Math.Abs(hAngle - mAngle);
            angle = Math.Min(angle, 360 - angle); // get narrowest angle
            return angle;
        }

        public string ReverseString(string str)
        {
            if (str.Length <= 1)
                return str;
            return ReverseString(str.Substring(1)) + str.Substring(0, 1);
        }

        public string ReverseString2(string str)
        {
            char[] letters = str.ToCharArray();
            int j = letters.Length - 1;
            for (int i = 0; i < j; i++)
            {
                var firstChar = letters[i];
                var secondChar = letters[j];
                letters[i] = secondChar;
                letters[j] = firstChar;
                j--;
            }
            return new string(letters);
        }

        /// <summary>
        /// Search on sorted array
        /// O = log n + 1 (log 8 = 3 (2^3 = 8))
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int BinarySearch(int[] arr, int val)
        {
            int lowIdx = 0;
            int highIdx = arr.Length - 1;
            int count = 0;
            while (lowIdx <= highIdx)
            {
                count++;
                int midIdx = (lowIdx + highIdx) / 2;
                if (arr[midIdx] == val)
                    return midIdx;
                if (arr[midIdx] < val)
                    lowIdx = midIdx + 1;
                else
                    highIdx = midIdx - 1;                
            }
            return -1;
        }

        public bool CompareString(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1.Substring(i, 1) != str2.Substring(i, 1))
                    return false;
            }
            return true;
        }

        public void HanoiTower(int diskNum, int fromTower, int toTower)
        {
            if (diskNum <= 1)
            {
                Console.WriteLine("{0}  Move disk from tower {1} to tower {2}", move++, fromTower, toTower);
            }
            else
            {
                int tempTower = 6 - fromTower - toTower; //find another tower from ( 1 + 2 + 3 = 6 )
                HanoiTower(diskNum - 1, fromTower, tempTower);
                HanoiTower(1, fromTower, toTower);
                HanoiTower(diskNum - 1, tempTower, toTower);
            }
        }

        /// <summary>
        /// Compute log of inpute value can compute only full log (GetLog(8,2) = 3, GetLog(9,2) = 3)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="baseValue"></param>
        /// <returns></returns>
        public static int GetLog(int value, int baseValue)
        {
            for (int i = 1; value >= Math.Pow(baseValue, i); i++)
            {
                var powerResult = Math.Pow(baseValue, i);
                if (value - powerResult < baseValue)
                    return i;
            }
            return 0;
        }

        /// <summary>
        /// Find minimum distance between 2 point in many points
        /// O = n^2
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        //public double FindClosetPointDistance(Point[] points)
        //{
        //    double minDistance = double.MaxValue;
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        for (int j = i + 1; j < points.Length; j++)
        //        {
        //            double d = Distance(ref points[i], ref points[j]);
        //            if (d < minDistance)
        //                minDistance = d;
        //        }
        //    }
        //    return minDistance;
        //}

        //private double Distance(ref Point p1, ref Point p2)
        //{
        //    int difX = p1.X - p2.X;
        //    int difY = p1.Y - p2.Y;

        //    return Math.Sqrt(difX * difX + difY * difY);
        //}

        //private void SortPointByX(Point[] points)
        //{ 

        //}
        /// <summary>
        /// Find minimum distance between 2 point in many points
        /// O = n^2
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        //public double FindClosetPointDistance(Point[] points)
        //{
        //    double minDistance = double.MaxValue;
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        for (int j = i + 1; j < points.Length; j++)
        //        {
        //            double d = Distance(ref points[i], ref points[j]);
        //            if (d < minDistance)
        //                minDistance = d;
        //        }
        //    }
        //    return minDistance;
        //}

        //private double Distance(ref Point p1, ref Point p2)
        //{
        //    int difX = p1.X - p2.X;
        //    int difY = p1.Y - p2.Y;

        //    return Math.Sqrt(difX * difX + difY * difY);
        //}

        ////private void SortPointByX(Point[] points)
        ////{ 

        ////}
        //public static Point GetClosestPointToMe(Point me, Point[] point)
        //{
        //    var closestPoint = new Point();
        //    return closestPoint;
        //}


    }
}
