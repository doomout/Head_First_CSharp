using System;
using System.Collections.Generic;

namespace _09_UseYieldReturn
{
    internal class Program
    {
        static IEnumerable<string> SimpleEnumerable()
        {
            yield return "apples";
            yield return "oranges";
            yield return "bananas";
            yield return "unicorns";
        }
        static void Main(string[] args)
        {
           foreach (var item in SimpleEnumerable()) 
                Console.WriteLine(item);
        }
    }
}
