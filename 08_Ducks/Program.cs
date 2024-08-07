﻿using System;
using System.Collections.Generic;

namespace _08_Ducks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Loon, Size = 14},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Loon, Size = 13},
            };
            //CompareTo 사용한 정렬
            ducks.Sort(); 
            PrintDucks(ducks);

            Console.WriteLine("--------------------------");

            //Compare(Size x, Size y) 를 사용한 정렬(오리의 사이즈 순)
            IComparer<Duck> sizeComparer = new DuckComparerBySize();
            ducks.Sort(sizeComparer); 
            PrintDucks(ducks);

            Console.WriteLine("--------------------------");

            //Compare(Kind x, Kind y) 를 사용한 정렬(오리의 종순)
            IComparer<Duck> kindComparer = new DuckComparerByKind();
            ducks.Sort(sizeComparer); 
            PrintDucks(ducks);

            Console.WriteLine("--------------------------");

            DuckComparer comparer = new DuckComparer();
            Console.WriteLine("\nSorting by kind then size\n");
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.WriteLine("--------------------------");

            Console.WriteLine("\nSorting by size then kind\n");
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                //기존 코드
                //Console.WriteLine($"{duck.Size} inch {duck.Kind}"); 
                //toString() 재정의한 코드
                Console.WriteLine(duck);
            }
        }
    }
}
