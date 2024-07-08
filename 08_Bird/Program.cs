using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Bird
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
            //오리 리스트를 새 클래스로 업 캐스팅
            IEnumerable<Bird> upcastDucks = ducks;
            //새에 있는 FlyAway() 메소드 사용
            Bird.FlyAway(upcastDucks.ToList(), "Minnesota");
        }
    }
}
