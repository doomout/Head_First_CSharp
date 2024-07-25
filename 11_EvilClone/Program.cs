using System;
using System.Collections.Generic;

namespace _11_EvilClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var clones = new List<EvilClone>();
            while (true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'a': //a를 누르면 객체 생성
                        clones.Add(new EvilClone()); 
                        break;
                    case 'c': //c를 누르면 모든 참조 제거
                        Console.WriteLine("Clearing list at time {0}", stopwatch.ElapsedMilliseconds);
                        clones.Clear();
                        break;
                    case 'g': //g를 누르면 CLR이 가비지 컬렉션 대상으로 표시된 모든 객체를 수집
                        Console.WriteLine("Collection at time {0}", stopwatch.ElapsedMilliseconds);
                        GC.Collect();
                        break;
                }
            }
        }
    }
}
