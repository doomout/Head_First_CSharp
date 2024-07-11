using System;

namespace _09_LinqTest
{
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 100; i++)
                numbers.Add(i);

            //Take(5) : 시작 부분에 있는 요소를 5개 가져옴 1,2,3,4,5
            //TakeLast(5) : 끝 부분에 있는 요소를 5개 가져옴 96,97,98,99,100
            //Concat() 두 데이터를 결합함 1,2,3,4,5,96,97,98,99,100
            IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));
            foreach (int i in firstAndLastFive)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
