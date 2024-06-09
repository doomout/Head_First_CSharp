using System;
using System.ComponentModel.Design;

namespace _03_personal_transaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guy 객체를 만들어 joe라는 변수에 할당을 축약으로
            Guy joe = new Guy() { Name = "joe", Cash = 50 };
            
            //Guy 객체를 만들어 bob라는 변수에 할당
            Guy bob = new Guy();
            //Name 필드의 값을 Bob로 설정
            bob.Name = "Bob";
            //Cash 필드의 값을 100으로 설정
            bob.Cash = 100;

            while (true)
            {
                //각 Guy 객체의 WriteMyInfo() 메서드를 호출
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("금액을 입력하세요 : ");

                string howMuch = Console.ReadLine();
                if(howMuch == "") return;
                // int.TryParse를 사용해 howMuch 문자열을 int로 변환
                //변환 성공 했는지 확인
                if(int.TryParse(howMuch, out int amount))
                {
                    Console.Write("현금은 누가 주어야 하나?: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "joe")
                    {
                        //joe 객체의 GiveCash() 메서드를 호출하고 결과를 저장
                        int present_cash =  joe.GiveCash(amount);
                        //bob 객체의 ReceiveCash() 메서드에 저장된 결과를 매개 변수로 넘겨주며 호출
                        bob.ReceiveCash(amount);
                    }
                    else if (whichGuy == "bob")
                    {
                        //bob 객체의 GiveCash() 메서드를 호출하고 결과를 저장
                        int present_cash = bob.GiveCash(amount);
                        //joe 객체의 ReceiveCash() 메서드에 저장된 결과를 매개 변수로 넘겨주며 호출
                        joe.ReceiveCash(amount);
                    }
                    else
                    {
                        Console.WriteLine("'Joe' 또는 'Bob'을 입력하세요.'");
                    }
                }
                else
                {
                    Console.WriteLine("금액을 입력하세요(종료하려면 빈 줄에 입력하세요).");
                }
            }
        }
    }
}
