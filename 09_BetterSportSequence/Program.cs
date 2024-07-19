using System;

namespace _09_BetterSportSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yield return 사용
            var sports = new BetterSportSequence();
            foreach (var sport in sports)
            {
                Console.WriteLine(sport);
            }
            //인덱서 사용
            var sequence = new BetterSportSequence();
            Console.WriteLine("---4번째 인덱스 값 출력---");
            Console.WriteLine(sequence[3]); //4번째 인덱스 값 출력
        }
    }
}
