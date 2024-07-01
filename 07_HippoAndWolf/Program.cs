using System;

namespace _07_HippoAndWolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { 
                new Wolf(false), // Wolf 객체 생성, 무리 속에 속하지 않음
                new Hippo(),     // Hippo 객체 생성
                new Wolf(true),  // Wolf 객체 생성, 무리 속에 속함
                new Wolf(false), // Wolf 객체 생성, 무리 속에 속하지 않음
                new Hippo()      // Hippo 객체 생성
            };
            foreach (Animal animal in animals)
            {
                animal.MakeNois(); // 각 동물이 소리를 내는 메서드 호출

                // 객체가 Hippo 타입인지 확인 후, 맞다면 Swim 메서드 호출
                if (animal is Hippo hippo)
                    hippo.Swim();

                // 객체가 Wolf 타입인지 확인 후, 맞다면 HuntInPack 메서드 호출
                if (animal is Wolf wolf)
                    wolf.HuntInPack();

                // 출력 결과 구분을 위한 빈 줄 추가
                Console.WriteLine();
            }
        }
    }
}
