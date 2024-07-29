using System;
using System.IO;

namespace _12_UseAFinallyBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstLine = "No first line was read";
            try
            {
                var lines = File.ReadAllLines(args[0]);
                firstLine = (lines.Length > 0) ? lines[0] : "The file was empty"; 
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Could not read lines from the file: {0}", ex);
            }
            finally
            {
                Console.WriteLine(firstLine);
            }
        }
    }
}
/** 실행결과
Could not read lines from the file: System.IndexOutOfRangeException: Index was outside the bounds of the array.
at _12_UseAFinallyBlock.Program.Main(String[] args) in 파일 위치
No first line was read
 */