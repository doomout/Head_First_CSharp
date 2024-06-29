using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Clowns
{
    // TallGuy 클래스는 IClowns 인터페이스를 구현합니다.
    internal class TallGuy : IClowns
    {
        // 이름과 키를 나타내는 필드입니다.
        public string Name;
        public int Height;

        // FunnyThingIHave 프로퍼티는 "big shoes"를 반환합니다.
        public string FunnyThingIHave
        {
            get { return "big shoes"; }
        }

        // Honk 메서드는 콘솔에 "Honk honk!"를 출력합니다.
        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }

        // TalkAboutYourself 메서드는 자신의 이름과 키를 콘솔에 출력합니다.
        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}
