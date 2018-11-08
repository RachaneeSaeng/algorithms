using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class SkyScanner
    {
        static string findNumber(List<int> arr, int k)
        {
            foreach (int item in arr)
            {
                if (item == k)
                {
                    return "YES";
                }
            }
            return "NO";
        }

        static List<int> oddNumbers(int l, int r)
        {
            var result = new List<int>();
            if (l % 2 == 0)
                l++;

            for (int i = l; i <= r; i+=2)
            {
                result.Add(i);
            }
            return result;
        }

        struct Destination
        {
            public string Name { get; set; }
            public int Count { get; set; }
        }

        public static void OutputMostPopularDestination(int count)
        {
            // keep count for each destination
            var searchCount = new Dictionary<string, int>();

            for (int i = 0; i < count; i++)
            {
                string destination = Console.ReadLine().Trim();
                if (searchCount.ContainsKey(destination))
                {
                    searchCount[destination]++;
                } else
                {
                    searchCount[destination] = 1;
                }                
            }

            // find the most popular country 
            var mostPopularDestination = new Destination();
            foreach (var sc in searchCount)
            {
                if (string.IsNullOrEmpty(mostPopularDestination.Name) || sc.Value > mostPopularDestination.Count)
                {
                    mostPopularDestination.Name = sc.Key;
                    mostPopularDestination.Count = sc.Value;
                }
            }

            // Print output
            PrintOutput(mostPopularDestination.Name);
        }

        static void PrintOutput(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
                textWriter.WriteLine(text);
                textWriter.Flush();
                textWriter.Close();
            }            
        }



        class Employee
        {
            public string Name { get; set; }
            public Employee Manager { get; set; }
            public Employee FirstUnderling { get; set; }
            public Employee SecondUnderling { get; set; }

            public Employee(string name)
            {
                this.Name = name;
            }
        }

        public static void OutputCommonManager(int count)
        {
            var firstName = Console.ReadLine().Trim();
            var secondName = Console.ReadLine().Trim();

            // create employee relationship graph
            var relationships = BuildEmployeeRelationship(count);


            // find fist common manager of the firstEmployee and secondEmployee
            var rootManager = FindRootManager(relationships);
            var firstEmployee = relationships.ContainsKey(firstName) ? relationships[firstName] : new Employee(firstName);
            var secondEmployee = relationships.ContainsKey(secondName) ? relationships[secondName] : new Employee(secondName);

            var firstCommonManager = FindFirstCommonManager(rootManager, firstEmployee, secondEmployee);

            // print result
            PrintOutput(firstCommonManager);
        }

        static Dictionary<string, Employee> BuildEmployeeRelationship(int count)
        {
            // build relationship graph
            var relationships = new Dictionary<string, Employee>();

            for (int i = 0; i < count - 1; i++)
            {
                string[] managementPair = Console.ReadLine().Trim().Split(' ');                
                if (managementPair.Length == 2)
                {
                    var manager = new Employee(managementPair[0]);
                    var underling = new Employee(managementPair[1]);

                    if (relationships.ContainsKey(managementPair[0]))
                    {
                        manager = relationships[managementPair[0]];
                    }
                    if (relationships.ContainsKey(managementPair[1]))
                    {
                        underling = relationships[managementPair[1]];
                    }
                    
                    if (manager.FirstUnderling == null)
                    {
                        manager.FirstUnderling = underling;
                    }
                    else if (manager.SecondUnderling == null)
                    {
                        manager.SecondUnderling = underling;
                    }
                }
            }

            // return the root manager            
            return relationships;
        }

        static Employee FindRootManager(Dictionary<string, Employee> relationships)
        {
            foreach (var rs in relationships)
            {
                var employee = rs.Value;
                if (employee.Manager == null)
                {
                    return employee;
                }
            }
            return null;
        }

        static string FindFirstCommonManager(Employee rootManager, Employee firstEmployee, Employee secondEmployee)
        {
            int diffLevel = Depth(firstEmployee) - Depth(secondEmployee);
            Employee first = diffLevel > 0 ? firstEmployee : secondEmployee;
            Employee second = diffLevel > 0 ? secondEmployee : firstEmployee;

            first = GoToUpperLevel(first, diffLevel);

            while (first != second && first != null && second != null)
            {
                first = first.Manager;
                second = second.Manager;
            }

            return first == null || second == null ? "" : first.Name;
        }

        static Employee GoToUpperLevel(Employee node, int level)
        {
            while (level > 0 && node != null)
            {
                node = node.Manager;
                level--;
            }
            return node;
        }

        static int Depth(Employee node)
        {
            int depth = 0;
            while (node != null)
            {
                node = node.Manager;
            }
            return depth;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<int> arr = new List<int>();

        //    for (int i = 0; i < arrCount; i++)
        //    {
        //        int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
        //        arr.Add(arrItem);
        //    }

        //    int k = Convert.ToInt32(Console.ReadLine().Trim());

        //    string res = findNumber(arr, k);

        //    textWriter.WriteLine(res);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
