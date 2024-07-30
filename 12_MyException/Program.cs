using System;

namespace _12_MyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("when it ");
            ExTestDrive.Zero("yes");
            Console.Write(" it ");
            ExTestDrive.Zero("no");
            Console.Write(".");
        }
    }
}
//실행결과
//when it thaws it throws.