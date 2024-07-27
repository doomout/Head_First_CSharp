using System;

namespace _11_StructDog
{
    /// <summary>
    /// 구조체와 객체의 다른 점 예제
    /// 구조체는 값 타입, 객체는 참조 타입
    /// 값은 복제되고, 참조는 할당된다.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //객체
            Canine spot = new Canine("Spot", "pug");
            
            //객체는 참조이므로 spot와 bob는 같은 객체(bob)를 참조하게 된다.
            Canine bob = spot;
            bob.Name = "Spike";
            bob.Breed = "beagle";
            //spot의 메서드를 호출해도 bob의 메서드를 호출하게 된다.
            spot.Speak(); //My name is Spike and I'm a beagle.
            
            //구조체
            Dog jake = new Dog("Jake", "podle");
            //구조체는 값 복사이기에 betty에 대입해도 jake의 값이 바뀌지 않는다.
            Dog betty = jake;
            betty.Name = "Betty";
            betty.Breed = "pit bull";
            //jake의 메서드를 호출하게 된다.
            jake.Speak(); //My name is Jake and I'm a podle.
        }
    }
}
/**실행결과
My name is Spike and I'm a beagle.
My name is Jake and I'm a podle.
*/