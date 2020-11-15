using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new Resume();
            //Console.WriteLine(doc.Pages.Count);
            Console.ReadLine();
        }
    }

    /// <summary>

    /// The 'Product' abstract class

    /// </summary>

    abstract class Page

    {
    }

    /// <summary>

    /// A 'ConcreteProduct' class

    /// </summary>

    class SkillsPage : Page

    {
    }

    abstract class Document

    {
        private readonly List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method

        public Document()
        {
            this.CreatePages();
        }

        //public List<Page> Pages => new ReadOnlyCollection<Page>(_pages);

        // Factory Method

        public abstract void CreatePages();
    }

    /// <summary>

    /// A 'ConcreteCreator' class

    /// </summary>

    class Resume : Document
    {
        // Factory Method implementation

        public override void CreatePages()
        {
            //Pages.Add(new SkillsPage());
        }
    }
}
