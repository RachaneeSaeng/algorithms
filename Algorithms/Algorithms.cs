using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms
{
    public enum SortDirection { Ascending, Descending };

    public class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Point otherPoint = obj as Point;
            if (otherPoint != null)
                return this.X.CompareTo(otherPoint.X);
            else
                throw new ArgumentException("Object is not a point");
        }
    }

    public static class Algorithms
    {
        #region Array

        public static bool CheckDuplicate1(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Add(arr[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckDuplicate2(int[] arr)
        {
            //better performance
            List<int> set = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i]))
                    return true;
                else
                    set.Add(arr[i]);
            }
            return false;
        }

        /// <summary>
        /// Min/Max sum of arr.lengt - 1 element
        /// Sort first and remove smallest number to find max sum and remove largest number to find min sum may be better
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string MinMaxSum(int[] arr)
        {
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            long min = long.MaxValue;
            long max = 0;
            for (int i = 0; i < 5; i++)
            {
                var sum = arr.Where((value, index) => index != i).Sum(value => Convert.ToInt64(value));
                if (sum < min)
                    min = sum;
                if (sum > max)
                    max = sum;
            }
            return string.Format("{0} {1}", min, max);
        }
        #endregion

        #region Sorting

        /// <summary>
        /// O = N * Log N
        /// The best performance is N
        /// set pivot at an index and make everything in left hand side less than it and right hand side more than it
        /// do recursively
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void QuickSort(int[] arr, int minIdx, int maxIdx)
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

        private static int Partition(int[] arr, int minIdx, int maxIdx)
        {
            int pivotValue = arr[minIdx];
            while (true)
            {
                while (arr[minIdx] < pivotValue) //Stop when found a value is not in the right place
                    minIdx++;

                while (pivotValue < arr[maxIdx]) //Stop when found a value is not in the right place
                    maxIdx--;

                if (minIdx < maxIdx) //some value stop counter in the upper conditions which make minIdx < maxIdx
                {                    
                    if (arr[minIdx] == arr[maxIdx]) //if both values are equal move them to pivot position                    
                        maxIdx--;
                       
                    int temp = arr[maxIdx];
                    arr[maxIdx] = arr[minIdx];
                    arr[minIdx] = temp;
                }
                else
                {
                    return maxIdx;
                }
            }
        }

        /// <summary>
        /// find the smallest in list and place in the right order
        /// like manual action
        /// </summary>
        /// <param name="a"></param>
        public static void SelectionSort(int[] a) //O = n^2
        {
            //int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < a.Length; j++) // get index of smallest value in remain list
                {
                    //count++;
                    if (a[j] < a[minIdx]) minIdx = j;
                }
                if (minIdx != i)
                {
                    int temp = a[minIdx];
                    a[minIdx] = a[i];
                    a[i] = temp; //swap smallest value to i
                }
            }
        }

        /// <summary>
        /// Start for second element and look back to left hand side 
        /// pick current value store in temp and compare the value the each values in left hand 
        /// if current value less than a value, then ship elements right and insert the current value at the right place
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertionSort(int[] ar) //O = n^2 , 0 = n
        {
            //better performance if some element sorted
            long count = 0;
            int len = ar.Length;
            for (int i = 1; i < len; i++)
            {
                var focusingValue = ar[i];
                var rightIndex = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (focusingValue < ar[j])
                    {
                        ar[j + 1] = ar[j];
                        rightIndex = j;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (rightIndex != i)
                    ar[rightIndex] = focusingValue;
            }
            Console.WriteLine(count);
        }

        public static void ShellSort(int[] arr) //O = n^3/2 , 0 = n
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

        // swap current and next index until current < next
        // like kid line arrangement, if you found someone is in wrong place then you swap him with next friend and see if he in the right place
        // do it from starting every time until everyone is in the right place
        //O = n^2
        public static void BubleSort(int[] arr)
        {
            bool isSorted = false;
            ///int count = 0;
            //sorting an array
            for (int i = 0; (i < arr.Length - 1) && !isSorted; i++) //This i is just for lopp counting 
            {
                isSorted = true;
                for (int j = 0; j < (arr.Length - 1 - i); j++)
                {
                    //count++;
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

        public static void MergeSortRecursive(int[] numbers, int left, int right)
        {
            int mid;

            if (left < right)
            {
                mid = (left + right) / 2;
                MergeSortRecursive(numbers, left, mid);
                MergeSortRecursive(numbers, (mid + 1), right);
                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        private static void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
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

        /// <summary>
        /// Start for second element and look back to left hand side 
        /// if current value less than prevoius value than swap until the value is in the right palce 
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
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
                    if (curVal < prevVal)
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
        /// Heapsort can be thought of as an improved selection 
        /// it divides its input into a sorted and an unsorted region, 
        /// and it iteratively shrinks the unsorted region by extracting the largest element and moving that to the sorted region
        /// </summary>
        private static int heapSize;
        public static void HeapSort(int[] arr)
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }
        }

        private static void Heapify(int[] arr, int idx)
        {
            int left = 2 * idx + 1;
            int right = 2 * idx + 2;
            int largestIdx = idx;
            if (left <= heapSize && arr[left] > arr[idx])
            {
                largestIdx = left;
            }

            if (right <= heapSize && arr[right] > arr[largestIdx])
            {
                largestIdx = right;
            }

            if (largestIdx != idx)
            {
                Swap(arr, idx, largestIdx);
                Heapify(arr, largestIdx);
            }
        }

        private static void Swap(int[] arr, int x, int y)//function to swap elements
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        #endregion

        #region Searching

        /// <summary>
        /// Search on sorted array
        /// O = log n (log 8 = 3 (2^3 = 8))
        /// best case = 1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int val)
        {
            int lowIdx = 0;
            int highIdx = arr.Length - 1;
            //int count = 0;
            while (lowIdx <= highIdx)
            {
                //count++;
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

        /// <summary>
        /// Star from toIdx as min and compare to toIndx-1 and select min from the 2 values and return as min
        /// then compare to toIndx-1-1 and return min
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="startIdx"></param>
        /// <param name="toIdx"></param>
        /// <returns></returns>
        public static int FindMin(int[] arr, int startIdx, int toIdx) //O = n
        {
            if (startIdx == toIdx)
                return arr[toIdx];
            else
            {
                int min = FindMin(arr, startIdx + 1, toIdx);
                if (arr[startIdx] < min)
                    return arr[startIdx];
                else
                    return min;
            }
        }

        #endregion

        #region Distance

        /// <summary>
        /// Find minimum distance between 2 point in many points
        /// O = n^2
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static double FindClosetPointDistanceNormal(List<Point> points)
        {
            double? minDistance = null;
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distanceSquare = DistanceSquare(points[i], points[j]);
                    if (!minDistance.HasValue || distanceSquare < minDistance)
                        minDistance = distanceSquare;
                }
            }
            return minDistance.HasValue ? Math.Sqrt(minDistance.Value) : -1;
        }

        private static double DistanceSquare(Point p1, Point p2)
        {
            int difX = p1.X - p2.X;
            int difY = p1.Y - p2.Y;

            return (difX * difX + difY * difY); // Actual distance is Sqrt(difX^2 + difY^2) but we don't need to so to improve performance
        }

        /// <summary>
        /// Find minimum distance between 2 point in many points
        /// O = n log n
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static double FindClosetPointDistance(List<Point> points)
        {
            points.Sort();
            if (points.Count < 1)
            {
                return -1;
            }
            else
            {
                return ClosetPointDistance(points, 0, points.Count - 1);
            }
        }

        private static double ClosetPointDistance(List<Point> points, int leftIdx, int rightIdx)
        {
            if (leftIdx >= rightIdx)
            {
                return double.MaxValue;
            }
            if (leftIdx + 1 == rightIdx)
            {
                return Math.Sqrt(DistanceSquare(points[leftIdx], points[rightIdx]));
            }

            // Find closest point in left side and right side
            int midIdx = (leftIdx + rightIdx) / 2;
            double closestLeft = ClosetPointDistance(points, leftIdx, midIdx);
            double closestRight = ClosetPointDistance(points, midIdx + 1, rightIdx);
            double delta = Math.Min(closestLeft, closestRight);
            if (delta == 0)
            {
                return 0;
            }

            // find closest point on each point having X-Xmid < delta
            double centerIdx = (points[midIdx].X + points[midIdx + 1].X) / 2.0;
            List<int> leftPotentialPoints = new List<int>();
            List<int> rightPotentialPoints = new List<int>();
            for (int i = leftIdx; i <= midIdx; i++)
            {
                double d = centerIdx - points[i].X;
                if (d < delta)
                    leftPotentialPoints.Add(i);
            }
            for (int j = midIdx + 1; j <= rightIdx; j++)
            {
                double d = points[j].X - centerIdx;
                if (d < delta)
                    rightPotentialPoints.Add(j);
            }

            foreach (int i in leftPotentialPoints)
            {
                foreach (int j in rightPotentialPoints)
                {
                    double d = Math.Sqrt(DistanceSquare(points[i], points[j]));
                    if (d < delta)
                        delta = d;
                }
            }

            return delta;
        }


        //public static Point GetClosestPointToMe(Point me, Point[] point)
        //{
        //    var closestPoint = new Point();
        //    return closestPoint;
        //}

        public static void GetShortestPath() { }

        public static double DistancePointToLine()
        {
            return 0;
        }
        #endregion

        #region Math

        public static int Factorial(int n) //O = n
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public static int Fibonacci(int n) //O = n
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        public static char Random()
        {
            char[] charArr = new char[] { 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'D' };
            Random rnd = new Random();
            return charArr[rnd.Next(10)];
        }

        public static char Random2()
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

        /// <summary>
        /// Print pair numbe in sorted list that can sum of them = n
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public static void PrintPair(int[] arr, int n)
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

        public static bool IsPrime(int number)
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

        #endregion

        #region String

        /// <summary>
        /// Find index of word recursively
        /// </summary>
        /// <param name="str"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int IndexOfWord(string str, string word)
        {
            if (word.Length > str.Length)
                return -1;

            if (string.Compare(str.Substring(0, word.Length), word) == 0)
                return 0;
            else
            {
                int foundIdx = 1 + IndexOfWord(str.Substring(1), word);
                return (foundIdx == -1 ? -1 : foundIdx);
            }
        }

        /// <summary>
        /// Reverse string by move right sting to left char by char recursively
        /// O = N (n-1)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString(string str)
        {
            if (str.Length <= 1)
                return str;
            return ReverseString(str.Substring(1)) + str.Substring(0, 1);
        }

        /// <summary>
        /// Reverse string by swap left and right string
        /// O = N (n/2)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString2(string str)
        {
            char[] letters = str.ToCharArray();
            int j = letters.Length - 1;
            for (int i = 0; i < j; i++)
            {
                var leftChar = letters[i];
                var rightChar = letters[j];
                letters[i] = rightChar;
                letters[j] = leftChar;
                j--;
            }
            return new string(letters);
        }

        /// <summary>
        /// Check if 2 strings is same
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns> 
        public static bool CompareString(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            char[] str1Chars = str1.ToCharArray();
            char[] str2Chars = str2.ToCharArray();
            for (int i = 0; i < str1Chars.Length; i++)
            {
                if (str1Chars[i] != str2Chars[i])
                    return false;
            }
            return true;
        }
        
        public static string ReplaceString(string str)
        {
            var chars = str.Trim().ToCharArray();
            var originalLen = chars.Length;

            int spaceCount = 0;
            foreach (var c in chars)
            {
                if (c == ' ')
                    spaceCount++;
            }

            int newIndex = originalLen + (spaceCount * 2) - 1;

            for (int orgIndex = originalLen-1; orgIndex >= 0; orgIndex--)
            {
                if(chars[orgIndex] == ' ')
                {
                    chars[newIndex] = '0';
                    chars[newIndex-1] = '2';
                    chars[newIndex-2] = '%';
                    newIndex -= 3;
                }
                else
                {
                    chars[newIndex] = chars[orgIndex];
                    newIndex--;
                }
            }
            return chars.ToString();
        }

        /// <summary>
        /// Compares the two strings based on letter pair matches
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>The percentage match from 0.0 to 1.0 where 1.0 is 100%</returns>
        public static double CompareStringSimilarity(string str1, string str2)
        {
            List<string> pairs1 = WordLetterPairs(str1.ToUpper());
            List<string> pairs2 = WordLetterPairs(str2.ToUpper());

            int intersection = 0;
            int totalCount = pairs1.Count + pairs2.Count;

            for (int i = 0; i < pairs1.Count; i++)
            {
                for (int j = 0; j < pairs2.Count; j++)
                {
                    if (pairs1[i] == pairs2[j])
                    {
                        intersection++;
                        pairs2.RemoveAt(j);//Must remove the match to prevent "GGGG" from appearing to match "GG" with 100% success
                        break;
                    }
                }
            }

            return (2.0 * intersection) / totalCount;
        }
        /// <summary>
        /// Gets all letter pairs for each
        /// individual word in the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static List<string> WordLetterPairs(string str)
        {
            List<string> allPairs = new List<string>();

            // Tokenize the string and put the tokens/words into an array
            string[] words = Regex.Split(str, @"\s"); //\s= white space characters

            // For each word
            for (int w = 0; w < words.Length; w++)
            {
                string[] pairsInWord = LetterPairs(words[w]);
                allPairs.AddRange(pairsInWord);
            }
            return allPairs;
        }
        /// <summary>
        /// Generates an array containing every 
        /// two consecutive letters in the input string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string[] LetterPairs(string str)
        {
            string[] pairs = new string[str.Length - 1];
            for (int i = 0; i < str.Length - 1; i++)
            {
                pairs[i] = str.Substring(i, 2);
            }
            return pairs;
        }

        #endregion

        #region Metric

        public static int DiagonalDifferrent(int[][] squareMetric)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[][] a = new int[n][];
            //for (int a_i = 0; a_i < n; a_i++)
            //{
            //    string[] a_temp = Console.ReadLine().Split(' ');
            //    a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            //}

            int primaryDia = 0;
            int secondDia = 0;
            for (int i = 0; i < squareMetric.Length; i++)
            {
                primaryDia += squareMetric[i][i];
                secondDia += squareMetric[i][squareMetric.Length - i - 1];
            }

            return Math.Abs(primaryDia - secondDia);
        }

        #endregion

        #region Clock
        /// <summary>
        /// Find angle between hour hand and minute hand
        /// </summary>
        /// <param name="h"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double ClockAngle(int h, int m)
        {
            double hAngle = ((h % 12) + (Convert.ToDouble(m) / 60)) * 30; // 1 hour = 360/12 = 30
            double mAngle = m * 6; // 1 minutes = 360/60 = 6
            double angle = Math.Abs(hAngle - mAngle);
            angle = Math.Min(angle, 360 - angle); // get narrowest angle
            return angle;
        }

        /// <summary>
        /// Convert from AM/PM format to 24 hour format
        /// </summary>
        /// <param name="latinTime"></param>
        /// <returns></returns>
        public static string TimeConvertion(string latinTime)
        {
            var hour = Convert.ToInt32(latinTime.Substring(0, 2));
            var min = latinTime.Substring(3, 2);
            var second = latinTime.Substring(6, 2);
            var part = latinTime.Substring(8, 2).ToLower();

            var militaryHour = (hour == 12 ? 0 : hour);
            if (part == "pm")
                militaryHour += 12;

            return string.Format("{0:00}:{1}:{2}", militaryHour, min, second);
        }
        #endregion

        #region Grouping
        public static void Select2Astronauts()
        {
            string[] n_p = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(n_p[0]);
            int p = Convert.ToInt32(n_p[1]);

            List<int[]> arr = new List<int[]>();
            for (int i = 0; i < p; i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                arr.Add(Array.ConvertAll(a_temp, Int32.Parse));
            }

            List<HashSet<int>> countryHaveMultiAstros = new List<HashSet<int>>();
            while (arr.Count > 0)
            {
                var astrosInCountry = new HashSet<int>() { arr[0][0], arr[0][1] };

                var otherAstrosInCountry = arr.Where(set => astrosInCountry.Contains(set[0]) || astrosInCountry.Contains(set[1]));
                while (otherAstrosInCountry.Count() > 0)
                {
                    foreach (var items in otherAstrosInCountry.ToList())
                    {
                        astrosInCountry.Add(items[0]);
                        astrosInCountry.Add(items[1]);
                        arr.Remove(items);
                    }
                    otherAstrosInCountry = arr.Where(set => astrosInCountry.Contains(set[0]) || astrosInCountry.Contains(set[1]));
                }

                countryHaveMultiAstros.Add(astrosInCountry);
            }

            //Total methods for each astronauts
            long sumMethod = (long)n * (long)(n - 1) / 2;
            //Subtract methods for astronauts in same country
            foreach (var item in countryHaveMultiAstros)
            {
                sumMethod -= item.Count() * (item.Count() - 1) / (long)2;
            }

            Console.WriteLine(sumMethod);
        }
        #endregion

        #region Other

        /// <summary>
        ///  Given a set of items, each with a weight, determine the number of each item to include in a Knapsack which have capacity = totalWeight
        /// </summary>
        /// <param name="itemWeights"></param>
        /// <param name="startIdx"></param>
        /// <param name="totalWeight"></param>
        /// <returns></returns>
        public static int[] Knapsack(int[] itemWeights, int startIdx, int totalWeight)
        {
            if (totalWeight < 0 || startIdx >= itemWeights.Length)
                return new int[0];

            for (int i = startIdx; i < itemWeights.Length; i++)
            {
                if (itemWeights[i] == totalWeight)
                    return new int[] { itemWeights[i] };
                else
                {
                    int[] combinedWeight = Knapsack(itemWeights, i + 1, totalWeight - itemWeights[i]); // itemWeights[i] + Knapsack(next items having total weight = totalWeight - itemWeights[i]
                    if (combinedWeight.Length > 0)
                    {
                        int[] ans = new int[combinedWeight.Length + 1];
                        ans[0] = itemWeights[i];
                        for (int j = 0; j < combinedWeight.Length; j++)
                        {
                            ans[j + 1] = combinedWeight[j];
                        }
                        return ans;
                    }
                }
            }
            return new int[0];
        }

        /// <summary>
        /// Print solution for HanoiTower problem (move disk stack, bigest in bottom smallest in top, from a tower to another tower. big must under small all the time.)
        /// </summary>
        static int move = 1;
        public static void HanoiTower(int diskNum, int fromTower, int toTower)
        {
            if (diskNum <= 1)
            {
                Console.WriteLine("{0} Move disk from tower {1} to tower {2}", move++, fromTower, toTower);
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
        /// File key from provided condition
        /// </summary>
        /// <returns></returns>
        public static string FindKey()
        {
            var result = "";
            for (int i = 0; i <= 999; i++)
            {
                var A = i / 100;
                var B = (i % 100) / 10;
                var C = i % 10;

                var count = (A == 6 ? 1 : 0) + (B == 8 ? 1 : 0) + (C == 2 ? 1 : 0);
                if (count != 1)
                    continue;
                count = (A == 1 || A == 4 ? 1 : 0) + (B == 6 || B == 4 ? 1 : 0) + (C == 6 || C == 1 ? 1 : 0);
                if (count != 1)
                    continue;
                count = (A == 0 || A == 6 ? 1 : 0) + (B == 2 || B == 6 ? 1 : 0) + (C == 2 || C == 0 ? 1 : 0);
                if (count != 2)
                    continue;
                if (A == 7 || A == 3 || A == 8 || B == 7 || B == 3 || B == 8 || C == 7 || C == 3 || C == 8)
                    continue;
                count = (A == 7 || A == 0 ? 1 : 0) + (B == 8 || B == 0 ? 1 : 0) + (C == 8 || C == 7 ? 1 : 0);
                if (count != 1)
                    continue;
                result += string.IsNullOrEmpty(result) ? i.ToString("000") : "," + i.ToString("000"); //incase multi corrected values
            }
            return result;
        }

        public static void FindAstronuts()
        {
            string[] n_p = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(n_p[0]);
            int p = Convert.ToInt32(n_p[1]);

            List<int[]> arr = new List<int[]>();

            for (int i = 0; i < p; i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                arr.Add(Array.ConvertAll(a_temp, Int32.Parse));
            }

            List<List<int>> countries = new List<List<int>>();
            for (int i = 0; i < n - 1; i++)
            {
                if (countries.Where(list => list.Contains(i)).Count() == 0)
                {
                    var astrosInCountry = new List<int>();
                    astrosInCountry.Add(i);

                    while ((arr.Where(a => astrosInCountry.Contains(a[0]) || astrosInCountry.Contains(a[1]))).Count() > 0)
                    {
                        var otherAstrosInCountry = arr.Where(a => astrosInCountry.Contains(a[0]) || astrosInCountry.Contains(a[1]));
                        foreach (var items in otherAstrosInCountry.ToList())
                        {
                            astrosInCountry.AddRange(items);
                            arr.Remove(items);
                        }
                    }

                    countries.Add(astrosInCountry);
                }
            }

            var sumMethod = 0;
            for (int i = 0; i < countries.Count; i++)
            {
                var thisCountryCount = countries[i].Distinct().Count();
                var otherCountryCount = 0;
                for (int j = i + 1; j < countries.Count; j++)
                {
                    otherCountryCount += countries[j].Distinct().Count();
                }
                sumMethod += thisCountryCount * otherCountryCount;
            }

            Console.WriteLine(sumMethod);
        }

        public static void GetLargestCost()
        {
            int testNumber = Convert.ToInt32(Console.ReadLine());
            List<int[]> testCases = new List<int[]>();
            for (int i = 0; i < testNumber; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = "22 89 99 7 66 32 2 68 33 75 92 84 10 94 28 54 12 9 80 43 21 51 92 20 97 7 25 67 17 38 100 86 4 83 20 6 81 58 59 53 2 54 62 25 35 79 64 27 49 32 95 100 20 58 39 92 30 67 89 58 81 100 66 73 29 75 81 70 55 18 28 7 35 98 52 30 11 69 48 84 54 13 14 15 86 34 82 92 26 8 53 62 57 50 31 61".Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                testCases.Add(arr);
            }

            foreach (var test in testCases)
            {
                int loSum = 0;
                int hiSum = 0;
                for (int i = 1; i < test.Length; i++)
                {
                    // current is low
                    var lo2Lo = 0;
                    var hi2Lo = Math.Abs(test[i - 1] - 1);
                    // current is high
                    var lo2Hi = Math.Abs(test[i] - 1);
                    var hi2Hi = Math.Abs(test[i - 1] - test[i]);

                    var newLoSum = Math.Max(loSum + lo2Lo, hiSum + hi2Lo);
                    var newHiSum = Math.Max(loSum + lo2Hi, hiSum + hi2Hi);

                    loSum = newLoSum;
                    hiSum = newHiSum;
                }

                Console.WriteLine(Math.Max(loSum, hiSum));
            }
        }

        public static string DayOfProgrammer(int year)
        {
            int febDays = 28;
            if (year < 1918 && (year % 4) == 0)
                febDays = 29;
            else if (year == 1918)
                febDays = 15;
            else if (year > 1918 && ((year % 400) == 0 || ((year % 4) == 0 && (year % 100) != 0)))
                febDays = 29;

            int[] dayInMonths = new int[] { 31, febDays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int sumDays = 0;
            for (int i = 0; i < 12; i++)
            {
                sumDays += dayInMonths[i];
                if (sumDays >= 256)
                {
                    sumDays -= dayInMonths[i];
                    int remainDays = 256 - sumDays;
                    return string.Format("{0:00}.{1:00}.{2}", remainDays, i + 1, year);
                }
            }
            return "";
        }

        public static double FindGreatXor(long number)
        {
            var binary = Convert.ToString(number, 2);
            var binaryChar = binary.ToCharArray();
            var charCount = binaryChar.Length;
            double count = 0;

            for (int i = 1; i < charCount; i++)
            {
                if (binaryChar[i] == '0')
                {
                    count += Math.Pow(2, charCount - i - 1);
                }
            }
            return count;
        }

        public static string GetSmallestLarger(string s)
        {
            var sArr = s.ToCharArray();
            var sArrLen = sArr.Length;
            int i = sArrLen - 2;
            while (i >= 0)
            {
                if (sArr.Skip(i + 1).Any(c => c > sArr[i]))
                {
                    break;
                }
                i--;
            }

            if (i < 0)
                return "no answer";


            var minGreaterValue = sArr.Skip(i + 1).Where(c => c > sArr[i]).Min();
            var minGreaterIndex = sArr.ToList().LastIndexOf(minGreaterValue);
            var temp = sArr[i];
            sArr[i] = sArr[minGreaterIndex];
            sArr[minGreaterIndex] = temp;

            var remainArr = sArr.Skip(i + 1).ToList();
            remainArr.Sort();

            i++;
            foreach (var item in remainArr)
            {
                sArr[i] = item;
                i++;
            }
            return new string(sArr);

        }

        public static int Elevator(int n, int w, int c, int focusIdx, List<People> people)
        {
            int round = 0;
            List<People> passenger = new List<People>();
            int time = 0;
            var focusArrivalTime = people[focusIdx].ArriveTime;
            for (int i = 0; i <= focusIdx; i++)
            {
                if (time == 0 || people[i].ArriveTime <= time)
                {
                    if (passenger.Count == 0)
                        time = time > people[i].ArriveTime ? time + w : people[i].ArriveTime + w;

                    passenger.Add(people[i]);

                    if (passenger.Count == c)
                    {
                        //Teacher first                                               
                        while (passenger.Any(p => p.Type == 1) && people.Skip(i + 1).Any(p => p.Type == 2 && p.ArriveTime <= time))
                        {
                            var student = passenger.Last(p => p.Type == 1);
                            var tc = people.Skip(i + 1).First(p => p.Type == 2 && p.ArriveTime <= time);

                            people.Remove(tc);

                            var studentInPeople = people.First(p => p.ArriveTime == student.ArriveTime);
                            people[people.IndexOf(studentInPeople)] = tc;
                            people.Insert(i + 1, student);


                            passenger[passenger.IndexOf(student)] = tc;
                        }

                        focusIdx = people.IndexOf(people.First(p => p.ArriveTime == focusArrivalTime));
                        var focusPerson = passenger.FirstOrDefault(p => p.ArriveTime == people[focusIdx].ArriveTime);
                        if (focusPerson != null)
                            time += focusPerson.Floor;
                        else
                            time += passenger.Max(p => p.Floor) * 2;
                        passenger = new List<People>();
                        round++;
                    }
                }
                else
                {
                    if (passenger.Count > 0)
                    {
                        var focusPerson = passenger.FirstOrDefault(p => p.ArriveTime == people[focusIdx].ArriveTime);
                        if (focusPerson != null)
                            time += focusPerson.Floor;
                        else
                            time += passenger.Max(p => p.Floor) * 2;

                        round++;
                        passenger = new List<People>();
                    }

                    passenger.Add(people[i]);
                    time = time > people[i].ArriveTime ? time + w : people[i].ArriveTime + w;
                }

            }

            if (passenger.Count != 0)
            {
                round++;
                time += people[focusIdx].Floor;
            }

            return time;
        }

        public class People
        {
            public int Type { get; set; }
            public int ArriveTime { get; set; }
            public int Floor { get; set; }
            //public int DelayTime { get; set; }
        }

        public static bool HasBalancedBrackets(string str)
        {
            Dictionary<string, string> bracketPairs = new Dictionary<string, string>
            {
                { ")", "(" },
                { "}", "{" },
                { "]", "[" },
                { ">", "<" }
            };

            Stack s = new Stack();
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                string c = chars[i].ToString();
                if (IsFocusChar(c))
                {
                    if (bracketPairs.ContainsKey(c))
                    {
                        if (s.Count > 0 && s.Pop().ToString() == bracketPairs[c])
                            continue;
                        else
                            return false;
                    }
                    else
                    {
                        s.Push(c);
                    }
                }
            }
            return s.Count == 0;
        }

        private static bool IsFocusChar(string c)
        {
            return c == "(" || c == ")" || c == "{" || c == "}" || c == "[" || c == "]" || c == "<" || c == ">";
        }

        public static int BstDistance(int[] values, int node1, int node2)
        {
            if (values.Contains(node1) && values.Contains(node2))
            {
                Array.Sort(values);

                int midIdx = (values.Length) / 2;
                var root = values[midIdx];

                int node1Level = GetNodeLevel(values, node1, 0);
                int node2Level = GetNodeLevel(values, node2, 0);

                if (node1 < root && node2 > root || node1 > root && node2 < root)
                    node2Level = -node2Level;

                return Math.Abs(node1Level - node2Level);
            }
            return -1;
        }

        private static int GetNodeLevel(int[] values, int node, int currentLevel)
        {
            int midIdx = (values.Length) / 2;
            var root = values[midIdx];
            if (node == root)
            {
                return currentLevel;
            }
            else
            {
                if (values.Length <= 3)
                {
                    return currentLevel + 1;
                }
                else
                {
                    if (node < root)
                        return GetNodeLevel(values.Take(midIdx).ToArray(), node, currentLevel + 1);
                    else
                        return GetNodeLevel(values.Skip(midIdx + 1).Take(values.Length - midIdx - 1).ToArray(), node, currentLevel + 1);
                }
            }

        }
        #endregion

    }



}
