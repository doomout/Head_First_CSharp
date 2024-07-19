using System;

namespace _09_PowersOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(int i in new PowersOfTwo())
                Console.WriteLine($" {i}");
        }
    }
}
