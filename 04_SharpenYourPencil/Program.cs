using System;
using System.Runtime.CompilerServices;

namespace _04_SharpenYourPencil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elrphant locky = new Elrphant() { name = "로키;", EarSzie = 33 };
            Elrphant thor = new Elrphant() { name = "토르", EarSzie = 40 };

            Console.Write("1번은 로키, 2번은 토르, 3번은 둘이 교체 입니다. 선택은?");
            while (true)
            {
                char key = Console.ReadKey(true).KeyChar;
                Console.WriteLine("자넨 " + key + "을 선택 했어.");
                if (key == '1')
                {
                    Console.WriteLine("날 불렀는가? 로키");
                    thor.WhoAmI();
                }
                else if (key == '2')
                {
                    Console.WriteLine("날 불렀는가? 토르");
                    locky.WhoAmI();
                }
                else if (key == '3')
                {
                    Elrphant hoder; //hoder 변수를 선언 할 때 new를 사용 안함. 임시이기에 인스턴스를 생성할 필요 없음
                    hoder = locky;
                    locky = thor;
                    thor = hoder;
                    Console.WriteLine("로키와 토르를 바꿨어");
                }
                else
                {
                    Console.WriteLine("정신 안차리지? 1~3을 선택하라니깐?");
                    return;
                }
            }
        }
    }
}
