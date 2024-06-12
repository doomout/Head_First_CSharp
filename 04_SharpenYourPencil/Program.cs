using System;
using System.Runtime.CompilerServices;

namespace _04_SharpenYourPencil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSzie = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSzie = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant hoder; //hoder 변수를 선언 할 때 new를 사용 안함. 임시이기에 인스턴스를 생성할 필요 없음
                    hoder = lloyd;
                    lloyd = lucinda;
                    lucinda = hoder;
                    Console.WriteLine("References have been swapped");
                }
                else if (input == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSzie = 4321;
                    lloyd.WhoAmI();
                }
                else if (input == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}
