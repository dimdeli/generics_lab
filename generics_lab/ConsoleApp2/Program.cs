using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("foo");

            int sum = 0;
            foreach (int x in list) {
                sum += x;
            }

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
