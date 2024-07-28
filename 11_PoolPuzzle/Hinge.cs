using System;
using System.Collections.Generic;
using System.Text;

namespace _11_PoolPuzzle
{
    internal class Hinge
    {
        public int bulb; // 전구 수량을 저장하는 변수
        public Table garden; // 연결된 Table 객체를 저장하는 변수

        // garden 필드를 설정하는 메서드
        public void Set(Table a) => garden = a;

        // 연결된 Table 객체의 stairs 필드를 반환하는 메서드
        public string Table()
        {
            return garden.stairs;
        }
    }
}
