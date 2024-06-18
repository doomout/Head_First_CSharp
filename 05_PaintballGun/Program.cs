using System;

namespace _05_PaintballGun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = ReadInt(20, "Number of balls"); //탄환 수
            int magazineSize = ReadInt(16, "Magazin size"); //탄창 크기
            Console.Write($"Loaded [false]: "); 

            //TryParse가 값을 파싱하는데 실패하면 isLoaded는 기본 값인 false를 가지게 된다.
            bool.TryParse(Console.ReadLine(), out bool isLoaded); //총의 장전 여부

            //생성자로 초기화
            PaintballGun gun = new PaintballGun(numberOfBalls,  magazineSize, isLoaded); 
            while (true)
            {
                //Console.WriteLine($"{gun.GetBalls()} balls, {gun.GetBallsLoaded()} Loaded");
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} Loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARING: You're out of ammo");
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                //else if (key == '+') gun.SetBalls(gun.GetBalls() + PaintballGun.MAGAZINE_SIZE); //기존 코드
                else if (key == '+') gun.Balls += gun.MagazineSize;
                else if (key == 'q') return;
            }
        }
        static int ReadInt(int lastUseValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUseValue + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine(" using default value " + lastUseValue);
                return lastUseValue;
            }
        }
    }
}
