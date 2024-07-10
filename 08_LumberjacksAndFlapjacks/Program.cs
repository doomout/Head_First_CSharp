using System;
using System.Collections.Generic;

namespace _08_LumberjacksAndFlapjacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
            //사용자에게 나무꾼 이름 묻기
            string name;
            Console.Write("First lumberjack's name: ");
            
            while ((name = Console.ReadLine()) != " ")
            {
                //나무꾼에게 줄 플랩잭 개수 묻기
                Console.Write("Number of flapjacks: ");
                //사용자가 유요한 숫자를 입력하면
                if (int.TryParse(Console.ReadLine(), out int number))
                { 
                    Lumberjack lumberjack = new Lumberjack(name);

                    //그 숫자만큼 TakFlapjack() 호출
                    for (int i = 0; i < number; i++)
                    {
                        //임의의 플랩잭을 넘겨준다.
                        lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));
                    }
                    //나무꾼을 큐에 추가한다.
                    lumberjacks.Enqueue(lumberjack);
                }
                //사용자가 빈 줄을 입력할 때까지 계속 나무꾼을 추가한다.
                Console.Write("Next lumberjack's name (blank to end): ");
            }
            //사용자가 빈 줄을 입력하면 While 문을 사용해서 
            while (lumberjacks.Count > 0)
            {
                //Lunberjack 객채를 큐에서 하나씩 제거하면서 
                Lumberjack next = lumberjacks.Dequeue();
                //메세지 출력한다.
                next.EatFlapjacks();
            }
        }
    }
}
