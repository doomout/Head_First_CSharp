using System;
using System.Collections.Generic;
using System.Text;

namespace _07_HippoAndWolf
{
    internal class Hippo : Animal, ISwimmer
    {
        // 소리를 내는 메서드로, 하마의 경우 "Grunt."을 출력
        public override void MakeNois()
        {
            Console.WriteLine("Grunt.");
        }
        // 하마가 수영하는 동작을 표현하는 메서드
        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim!");
        }
    }
}
