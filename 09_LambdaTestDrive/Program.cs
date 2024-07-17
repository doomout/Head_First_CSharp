using System;
using System.Collections.Generic;
using System.Linq;

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
            var array = new[] { 1, 2, 3, 4 };
            //var result = from i in array select i * 2; // 이 코드를
            var result = array.Select(i  => i * 2); //이 코드로 리팩토링

            foreach(var i in result) 
                Console.WriteLine(i);

            var value = Program.GetRandomDouble(100);
            Program.PrintValue(value);

            int[] values = new int[] { 0,12,44,36,92,45,13,8 };
            /** 아래 Lenq 를
            IEnumerable<int> lenq_result =
                from v in values
                where v < 37
                orderby -v
                select v;
            */
            //아래와 같이 리팩터링 가능(메서드 체이닝 형태)
            var lenq_result = values.Where(v => v < 37).OrderBy(v => -v); 
        }
    }
}
