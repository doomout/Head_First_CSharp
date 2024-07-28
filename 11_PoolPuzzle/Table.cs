using System;
using System.Collections.Generic;
using System.Text;

namespace _11_PoolPuzzle
{
    internal struct Table
    {
        public string stairs; // 어떤 문자열을 저장하는 변수
        public Hinge floor; // 연결된 Hinge 객체를 저장하는 변수

        // floor 필드를 설정하는 메서드
        public void Set(Hinge b) => floor = b;

        // 다양한 타입의 인수를 처리하는 Lamp 메서드
        public void Lamp(object oil)
        {
            if (oil is int oilInt)
                floor.bulb = oilInt; // 인수가 정수일 경우, floor의 bulb 필드 설정
            else if (oil is string oilString)
                stairs = oilString; // 인수가 문자열일 경우, stairs 필드 설정
            else if (oil is Hinge vine)
                Console.WriteLine($"{vine.Table()}{floor.bulb}" + $"{stairs}");  // 인수가 Hinge 객체일 경우, 정보를 출력
        }
    }
}
