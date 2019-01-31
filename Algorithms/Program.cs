using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Diagnostics.Contracts;

namespace Algorithms
{

    class Program
    {
        delegate void TestDelegate(string s);

        static int n = 200000;
        static long[][] dp = new long[n][];
        static char[] ar = new char[n];
        static int mod = 1000000007;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //switch (args[0])
            //{
            //    case "":
            //        var p = 10;
            //        break;                
            //}

            //var people = new People[] { new People() };
            //var names = from person in people select person.GetName();
            //var nameArr = names.ToArray();
            //foreach (var name in names)
            //{
            //    Console.WriteLine();
            //}

            var b = new B();

            //int val = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            //int groups = Convert.ToInt32(Console.ReadLine());
            //List<int[]> arrGroups = new List<int[]>();
            //for (int i = 0; i < groups; i++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //    arrGroups.Add(arr);
            //}

            //n = Convert.ToInt32(Console.ReadLine());

            //byte[] inputBuffer = new byte[n + 2];
            //Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            //Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
            //string numbers = Console.ReadLine();

            //string numbers = Console.ReadLine();
            //ar = numbers.ToCharArray();

            //for (int i = 0; i < 20000; i++)
            //{
            //    dp[i] = new long[] { -1, -1, -1, -1, -1, -1, -1, -1 };
            //}

            //long ans = GetNumberHavingThisRemain(0, 0);


            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] squares_temp = Console.ReadLine().Split(' ');
            //int[] squares = Array.ConvertAll(squares_temp, Int32.Parse);
            //string[] tokens_d = Console.ReadLine().Split(' ');
            //int d = Convert.ToInt32(tokens_d[0]);
            //int m = Convert.ToInt32(tokens_d[1]);

            //int count = 0;
            //for (int i = 0; i <= n-m; i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < m; j++)
            //    {
            //        sum += squares[i+j];                   
            //    }

            //    if (sum == d)
            //        count++;
            //}
            //Console.WriteLine(count);

            //string[] tokens_r = Console.ReadLine().Split(' ');
            //int r = Convert.ToInt32(tokens_r[0]);
            //int c = Convert.ToInt32(tokens_r[1]);
            //for (int i = 0; i < r; i++)
            //{
            //    Console.WriteLine(new String('+', c).Replace("+", "..O.."));
            //    Console.WriteLine(new String('+', c).Replace("+", "O.o.O"));
            //    Console.WriteLine(new String('+', c).Replace("+", "..O.."));
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(new string('#',i).PadLeft(n));
            //}
            //string[] tokens_rb = Console.ReadLine().Split(' ');
            //int rb = Convert.ToInt32(tokens_rb[0]);
            //int rg = Convert.ToInt32(tokens_rb[1]);
            //int br = Convert.ToInt32(tokens_rb[2]);
            //int bg = Convert.ToInt32(tokens_rb[3]);
            //string[] tokens_gr = Console.ReadLine().Split(' ');
            //int gr = Convert.ToInt32(tokens_gr[0]);
            //int gb = Convert.ToInt32(tokens_gr[1]);

            //Console.WriteLine("{0} {1}", round, time);
            int[] ar = { 2, 4, 6, 8, 3 };
            //Console.WriteLine("{0}", string.Join(" ", ar.Select(v => v.ToString()).ToArray()));

            var x = ar.Sum(i => i);
            Console.ReadLine();

            //Stopwatch st = new Stopwatch();

            //TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };
            //myDel("Hello");

            //// To see when it call method dispose
            //testBlock();

            ////Test type parameter in generic
            //MyGen<int> m = new MyGen<int>();
            ////MyGen<ListClass> s = new MyGen<ListClass>(); //error Mygen get only not-nullanble type

            //// Regular Expression
            //var pattern = @"(The )(.+)( jump)";
            //var str = @"The quick jump brown jump start";
            //var matcheds = Regex.Match(str, pattern).Groups;
            //foreach (var item in matcheds)
            //{
            //    Console.WriteLine(item);
            //}

            ////var lc = new ListClass();
            ////lc.SetName(" ");
            ////Console.ReadLine();
        }

        static long GetNumberHavingThisRemain(int pos, int rem)
        {
            if (pos == n)
                return rem == 0 ? 1 : 0;

            if (dp[pos][rem] != -1)
                return dp[pos][rem];

            dp[pos][rem] = 0;
            if (pos + 1 <= n)
                dp[pos][rem] = GetNumberHavingThisRemain(pos + 1, (rem * 10 + (ar[pos] - '0')) % 8);
            if (pos + 1 <= n)
                dp[pos][rem] += GetNumberHavingThisRemain(pos + 1, rem);
            dp[pos][rem] %= mod;

            return dp[pos][rem];
        }

        static void setArrayElement(long[] arr)
        {
            for (int i = 0; i < 8; i++)
            {
                arr[i] = -1;
            }
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
        public int MyProperty { get; set; }

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

    public interface IT1
    {
        void Sggg();
    }
    public interface IT2
    {
        void Sggg();
    }

    public class A : IT1, IT2
    {
        public readonly int MyProperty = 0;

        public A()
        {
            Console.WriteLine("A");
        }
        void IT1.Sggg()
        {
            throw new NotImplementedException();
        }
        void IT2.Sggg()
        {
            throw new NotImplementedException();
        }
    }

    public class B : A
    {
        public B() : base()
        {
            //MyProperty = 20;
            Console.WriteLine("B");
        }

        public unsafe void Check()
        {
            int i = 10;
            int* pi = &i;

            string[,] s1;
            string[][] s2;
        }
    }
    public class People
    {
        public int Type { get; set; }
        public int ArriveTime { get; set; }
        public int Floor { get; set; }
        //public int DelayTime { get; set; }

        //private int h;
        //public int H
        //{
        //    get { return h; }
        //    set { h = value; }
        //}

        //public void set_H(int h) {
        //    this.h = h;
        //    }
    }

    public static class UtilClass
    {
        public static string GetName(this People p)
        {
            throw new InvalidCastException();
        }
    }
}
