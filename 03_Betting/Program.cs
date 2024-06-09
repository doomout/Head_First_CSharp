using _03_personal_transaction;
using System;
using System.Runtime.InteropServices;

namespace _03_Betting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The player", Cash = 100 };

            player.WriteMyInfo();
            Console.WriteLine("돈을 걸어서 이기면 2배로 주지 지면 내가 먹는다.");
            Console.WriteLine("지금부터 게임을 시작하지.(확율 : " + odds + ") "  );

            while (player.Cash > 0) 
            {
                Console.WriteLine("지금 자네의 돈은  " + player.Cash + "원이야.");
                string howMuch =  Console.ReadLine();
                if (howMuch == "")
                {
                    Console.WriteLine("장난하냐? 입력을 안해? 엎드려");
                    return;
                }
                if(int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if(pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("오~ 이겼네?" + winnings + " 원 땄어.");
                            player.ReceiveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("자넨 졌어 ㅋ 이 돈은 내가 냠냠");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("자넨 숫자를 모르나? 숫자만 넣으라고!");
                }
            }
            Console.WriteLine("난 언제나 이기지 ㅋㅋㅋㅋㅋㅋㅋ");
        }
    }
}
