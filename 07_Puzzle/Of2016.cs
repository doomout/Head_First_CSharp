using System;

namespace _07_Puzzle
{
    internal class Of2016 : Clowns
    {
        // Face 속성을 재정의함
        public override string Face
        {
            get { return "Of2016"; }
        }
        static void Main(string[] args)
        {
            string result = ""; // 결과를 저장할 문자열 변수
            INose[] i = new INose[3];  // INose 인터페이스 배열 생성
            i[0] = new Acts();  // Acts 객체 할당
            i[1] = new Clowns(); // Clowns 객체 할당
            i[2] = new Of2016(); // Of2016 객체 할당

            // 각 객체의 Ear 메서드와 Face 속성을 호출하여 결과 문자열에 추가
            for (int x = 0; x < 3; x++)
            {
                result += $"{i[x].Ear()} {i[x].Face}\n";
            }
            Console.WriteLine(result);
            Console.ReadKey(); // 키 입력 대기
        }
    }
}
