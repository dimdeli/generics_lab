using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public interface IVecicle
        {
            int Rodes { get; }

            string GetInfo();
        }

        public class Car : IVecicle
        {
            public int Rodes => 4;

            public string GetInfo()
            {
                return $"Rodes: {Rodes}";
            }
        }


    }
}
