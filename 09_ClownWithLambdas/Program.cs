using System;

namespace _09_ClownWithLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TallGuy 객체를 생성하고 초기화합니다.
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "kim" };

            // TalkAboutYourself 메서드를 호출하여 자기소개를 출력합니다.
            tallGuy.TalkAboutYourself();

            // FunnyThingIHave 프로퍼티를 사용하여 재미있는 물건을 출력합니다.
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");

            // Honk 메서드를 호출하여 "Honk honk!"를 출력합니다.
            tallGuy.Honk();
        }
    }
}
