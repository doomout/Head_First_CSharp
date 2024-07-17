using System;

namespace _09_LambdaTestDrive
{
    internal class Program
    {
        static Random Random = new Random();

        /** 기존 코드
        static double GetRandomDouble(int max)
        {
            return max * Random.NextDouble();
        }
        */
        //위 코드를 아래 람다식으로 리팩토링
        static double GetRandomDouble(int max) => max * Random.NextDouble();

        /**기존 코드
        static void PrintValue(double d)
        {
            Console.WriteLine($"The value is {d:0.0000}");
        }
        */
        //위 코드를 아래 람다식으로 리팩토링
        static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}");
        static void Main(string[] args)
        {
            var value = Program.GetRandomDouble(100);
            Program.PrintValue(value);
        }
    }
}
