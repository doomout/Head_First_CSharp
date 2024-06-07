using System;
using System.Runtime.InteropServices;

namespace _03_PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("선택할 카드 수를 입력하세요.");
            string line  = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                // line 을 int 로 변환할 수 있으면 변환된 int 값은 numberOfCards 변수에 저장되고 이 코드 블록  실행
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                // lind 을 int로 변환할 수 없으면 이 코드 블록 실행
                Console.WriteLine("입력한 값이  유요하지 않습니다.");
            }
        }
    }
}
