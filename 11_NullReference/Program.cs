using System;
using System.IO;

namespace _11_NullReference
{
#nullable enable
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var stringReader = new StringReader(""))
            {
                //?? 연산자는 반환 값이 null일 경우 대체 값을 반환한다.
                var nextLine = stringReader.ReadLine() ?? String.Empty; //null 일 때 ""를 반환한다.

                //??= 연산자는 반환 값이 null인지 아닌지 검사하고 null이면 할당된 값을 반환한다.
                nextLine ??= "(the first line was empty)";
                Console.WriteLine("Line length is: {0}", nextLine.Length);
            }
        }
    }
}
