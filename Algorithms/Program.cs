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
            Stopwatch st = new Stopwatch();

            TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };
            myDel("Hello");

            // To see when it call method dispose
            testBlock();

            //Test type parameter in generic
            MyGen<int> m = new MyGen<int>();
            //MyGen<ListClass> s = new MyGen<ListClass>(); //error Mygen get only not-nullanble type

            // Regular Expression
            var pattern = @"(The )(.+)( jump)";
            var str = @"The quick jump brown jump start";
            var matcheds = Regex.Match(str, pattern).Groups;
            foreach (var item in matcheds)
            {
                Console.WriteLine(item);
            }

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
