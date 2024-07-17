using System;
using System.Collections.Generic;
using System.Text;

namespace _09_ClownWithLambdas
{
    internal class TallGuy : IClown
    {
        // 이름과 키를 나타내는 필드입니다.
        public string Name;
        public int Height;

        //람다식으로 인터페이스 구현
        public string FunnyThingIHave => "big red shoes";

        public void Honk() => Console.WriteLine("Honk honk!");

        // TalkAboutYourself 메서드는 자신의 이름과 키를 콘솔에 출력합니다.
        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}
