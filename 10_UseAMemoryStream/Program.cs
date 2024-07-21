using System;
using System.IO;
using System.Text;

namespace _10_UseAMemoryStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. MemoryStream 이 닫혀야 안전하게 닫힌다.
            using (var ms = new MemoryStream())
            {
                //1. StreamWriter 이 먼저 닫히고
                using (var sw = new StreamWriter(ms))
                {
                    sw.WriteLine("The value is {0:000}", 123.45678);
                }
                Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
            }
        }
    }
}
