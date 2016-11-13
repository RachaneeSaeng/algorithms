using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;
using System.Text.RegularExpressions;
//using System.Diagnostics.Contracts;

namespace Algorithms
{
    class Program
    {
        delegate void TestDelegate(string s);

        static void Main(string[] args)
        {
            Algorithms c = new Algorithms();
            Stopwatch st = new Stopwatch();

            //int[] arr = { 1, 45, 8, 9, 10, 2, 3, 4, 5, 6, 9 };

            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (c.IsPrime(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(c.Factorial(5));
            //Console.WriteLine(c.Fibonacci(3));
            //Console.WriteLine(c.Random2());
            //Console.WriteLine(c.FindMin(arr, 0, arr.Length-1));
            //Console.WriteLine(c.IndexOfWord("123456","34"));
            //int[] comWeight = c.Knapsack(arr, 1, 20);
            //for (int i = 0; i < comWeight.Length; i++)
            //{
            //    Console.WriteLine(comWeight[i]);
            //}

            //List<int?> gg = c.GetTwoBig(new int[] { 10,20,30,10,20,30 });
            //foreach (int x in gg)
            //{
            //    Console.WriteLine(x);
            //}

            //string[] yy = { "avd", "def", "fed" };


            //c.Sort(arr, SortDirection.Ascending);
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            //c.SelectionSort(arr);
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            //c.InsertionSort(arr);
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            //c.ShellSort(arr);
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            //c.BubleSort(arr);
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            //c.MergeSort_Recursive(arr,0,arr.Length-1);
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] a = { 1, 2, 3, 8, 9, 10, 15, 20, 21, 23, 27, 60, 70 };
            //c.PrintPair(a, 3);   

            //st.Restart();
            //bool y = c.CheckDuplicate2(a);
            //st.Stop();
            //Console.WriteLine("elapse time2 = " + st.ElapsedTicks);

            //st.Restart();
            //bool x = c.CheckDuplicate1(a);
            //st.Stop();
            //Console.WriteLine("elapse time1 = " + st.ElapsedTicks);



            //Console.WriteLine("angle = " + c.ClockAngle(19,0));

            //Console.WriteLine(c.ReverseString("ABCDEF"));

            //Console.WriteLine(c.BinarySearch(a,9));

            //Console.WriteLine(c.compareString("122","123"));


            //c.HanoiTower(6, 1, 3);

            //List<int> list = new List<int>();
            //for (int i = 0; i < 50000; i++)
            //{
            //    list.Add(i);
            //}

            //Dictionary<int,int> dic = new Dictionary<int,int>();
            //for (int i = 0; i < 50000; i++)
            //{
            //    dic.Add(i, i);
            //}

            //st.Restart();
            //for (int i = 0; i < 50000; i++)
            //{
            //    int x = dic[i];
            //}
            //st.Stop();
            //Console.WriteLine("elapse for dictionary = " + st.ElapsedTicks);

            //st.Restart();
            //for (int i = 0; i < 50000; i++)
            //{
            //    int x = list[i];
            //}
            //st.Stop();
            //Console.WriteLine("elapse for list = " + st.ElapsedTicks);


            //TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };
            //myDel("Hello");

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var firstNumbersLessThan5 = numbers.Skip(2);
            //int oddNumbers = numbers.Count(n => n % 2 == 1);

            //var firstNumbersLessThan6 = numbers.SkipWhile(n => n < 6);
            //foreach (var item in firstNumbersLessThan6)
            //{
            //    Console.WriteLine("firstNumbersLessThan6 " + item);
            //}
            //var firstSmallNumbers = numbers.TakeWhile(n => n < 6);
            //foreach (var item in firstSmallNumbers)
            //{
            //    Console.WriteLine("firstSmallNumbers " + item);
            //}

            Algorithms obj = new Algorithms();
            int y = obj.x;
            obj.SetValue();
            y = obj.x;

            obj.SetValue(obj.x);
            y = obj.x;

            Console.ReadLine();


            //foreach (var item in lc)
            //{
            //    Console.WriteLine(item);
            //}

            //ListClass lc = new ListClass();
            //List<int> l1 = new List<int>() { 1, 4, 5, 6, 10};
            //List<int> l2 = new List<int>() { 7, 8, 5, 6 };
            //foreach (var item in lc.Union(l1, l2))
            //{
            //    Console.WriteLine(item);
            //}

            //MyStruct m = new MyStruct();
            //int i = MyStruct.x;
            //lc = m.lc;

            //testBlock();
            //MyGen<int> m = new MyGen<int>();
            //MyGen<ListClass> s = new MyGen<ListClass>(); //error

            //using (var ct = new MyClass())
            //{

            //}

            //var pattern = @"(The )(.+)( jump)";
            //var s = @"The quick jump brown jump start";
            //var m = Regex.Match(s, pattern).Groups;
            //foreach (var item in m)
            //{
            //    Console.WriteLine(item);
            //}

            //var lc = new ListClass();
            //lc.SetName(" ");
            //Console.ReadLine();
        }

        static void testBlock()
        {
            MyClass mc = new MyClass();
            Console.WriteLine("222");
            mc.Dispose();
        }
    }

    public class MyClass : IDisposable
    {
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // called via myClass.Dispose(). 
                    // OK to use any private object references
                }

                disposed = true;
            }
        }

        public void Dispose() // Implement IDisposable
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~MyClass() // the finalizer
        {
            Dispose(false);
        }
    }

    public class ListClass
    {
        public string MyProperty { get; set; }
        public void SetName(string value)
        {
            //Contract.Requires(!string.IsNullOrEmpty(value), "not allow empthy");
            MyProperty = value;
        }

        public static int t = 500;
        public int o = 300;

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i * i;
            }
        }

        public IEnumerable<int> Union(List<int> l1, List<int> l2)
        {
            foreach (var item in l1)
            {
                yield return item;
            }
            foreach (var item in l2)
            {
                yield return item;
            }
        }

        ~ListClass()
        {

        }
    }

    class ListClass2 : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            for (int i = 10; i > 0; i--)
            {
                yield return i * i;
            }
        }
    }

    class ListClass3 : IEnumerator
    {
        int i = 0;
        public object Current
        {
            get { return i; }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    public struct MyStruct
    {
        //public MyStruct(int i)
        //{
        //    lc = new ListClass();
        //}
        public const int x = 10;
        public ListClass lc;
    }

    public struct MyGen<T> where T : struct
    {

    }
}
