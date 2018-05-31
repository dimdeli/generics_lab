using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Logger();

            l1.Value = "foo";
            l1.Save();

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
    }
}
