using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Logger();

            l1.Value = "foo";
            l1.Save();

            var l2 = new Logger2();

            l2.Value = 123;
            l2.Save();

            #region after Generics

            //var l1 = new GenericLogger<string>();

            //l1.Value = "foo";
            //l1.Save();

            //var l2 = new GenericLogger<int>();

            //l2.Value = 123;
            //l2.Save();

            #endregion

            Console.ReadLine();
        }

        public class Logger
        {
            public string Value { get; set; }

            public void Save()
            {
                Console.WriteLine($"{Value}");
            }
        }

        public class Logger2
        {
            public int Value { get; set; }

            public void Save()
            {
                Console.WriteLine($"{Value}");
            }
        }

        #region after Generics

        public class GenericLogger<T>
        {
            public T Value { get; set; }

            public void Save()
            {
                Console.WriteLine($"{Value}");
            }
        }

        #endregion
    }
}
