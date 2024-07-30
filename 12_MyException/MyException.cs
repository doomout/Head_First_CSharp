using System;
using System.Collections.Generic;
using System.Text;

namespace _12_MyException
{
    internal class MyException : Exception{ }

    class ExTestDrive
    {
        public static void Zero(string test)
        {
            try
            {
                Console.Write("t");
                DoRisky(test);
                Console.Write("o");
            }
            catch (MyException) //사용자 정의 예외 처리
            {
                Console.Write("a");
            }
            finally
            {
                Console.Write("w");
            }
            Console.Write("s");
        }

        private static void DoRisky(string t)
        {
            Console.Write("h");
            if(t == "yes")
            {
                throw new MyException();
            }
            Console.Write("r");
        }
    }
}
