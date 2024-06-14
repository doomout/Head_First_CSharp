using System;

namespace _05_SwordDamage_Console_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. SwordDamage 와 Random 클래스의 새 인스턴스 만들기
            SwordDamage sd = new SwordDamage();
            Random random = new Random();

            while (true)
            {
                //2. 콘솔에 메시지를 출력하고 사용자의 입력을 받는 코드 0~3 중 하나가 아닌 경우 프로그램 종료
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit : ");
                char key = Console.ReadKey().KeyChar;
                if (!(key == '0' || key == '1' || key == '2' || key == '3')) return;

                //3. random.Next(1,7)을 3번 호출해 주사위 3개를 랜덤으로 굴리고, 결과를 합산해서 roll 변수에 저장
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                sd.Roll = roll;

                //4. 1이나 3을 입력하면 SetMagic(true)를 호출. 아닌 경우 SetMagic(false) 호출 key == '1'은 true를 반환 || 를 사용해서 if문 사용 안함
                sd.SetMagic(key == '1' || key == '3');

                //5. 2 나 3을 입력하면 SetFlaming(true) 호출. 아닌 경우 SetFlaming(false) 호출 == 연산자와 || 사용하면 한줄 짜리 명령어 가능
                sd.SetFlaming(key == '2' || key == '3');

                //6. 콘솔에 결과 출력 줄바꿈은 \n
                Console.WriteLine("\nRolled " + roll + " for " + sd.Damage + " HP\n");
            }
        }
    }
}
