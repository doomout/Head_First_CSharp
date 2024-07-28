using System;

namespace _11_CheckTemperature
{
    internal class Program
    {
        //선택적 매개 변수로 기본값 설정하기
        static void CheckTemperature(double temp, double tooHigh = 99.5, double tooLow = 96.5)
        {
            if (temp < tooHigh && temp > tooLow)
                Console.WriteLine("{0} degrees F - feeling good!", temp);
            else
                Console.WriteLine("Uh-oh {0} degress F -- better see a doctor!", temp);
        }
        static void Main(string[] args)
        {
            // 사람에게는 기본값
            CheckTemperature(101.3);
            // 개의 체온은 화씨 100.5~102.5 사이여야 한다.
            CheckTemperature(101.3, 102.5, 100.5);
            // Bob의 체온은 항상 낮으니 tooLow를 95.5로 설정한다.
            CheckTemperature(96.2, tooLow: 95.5);
        }
    }
}
/** 실행 결과
Uh - oh 101.3 degress F -- better see a doctor!
101.3 degrees F - feeling good!
96.2 degrees F - feeling good!
*/