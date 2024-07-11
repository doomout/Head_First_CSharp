using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_JimmyLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<Comic> mostExpensive = //Comic를 반환했었음
            var mostExpensive =
                from comic in Comic.Catalog   
                where Comic.Prices[comic.Issue] > 500 //500달러 이상
                orderby Comic.Prices[comic.Issue] descending //내림차순으로 정렬
                select comic;
           
            foreach (Comic comic in mostExpensive)
            {
                Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
            }
        }
    }
}
