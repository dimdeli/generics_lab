using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            #region after Generics

            //var list1 = new List<int>();
            //list1.Add(1);
            //list1.Add(23);

            //var list2 = new List<string>();
            //list2.Add("foo");
            //list2.Add("bar");

            //foreach (int x in list1) {
            //    Console.WriteLine(x);
            //}

            //foreach (string x in list2) {
            //    Console.WriteLine(x);
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
