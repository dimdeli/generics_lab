using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The .NET Framework 1.1 way to create a list:
            var list1 = new ArrayList();
            list1.Add(1);
            list1.Add(23);

            var list2 = new ArrayList();
            list2.Add("foo");
            list2.Add("bar");

            foreach (int x in list1) {
                Console.WriteLine(x);
            }

            foreach (string x in list2) {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
