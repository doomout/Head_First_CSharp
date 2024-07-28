using System;

namespace _11_ReturnThreeValues
{
    internal class Program
    {
        //out 매개 변수는 한 개 이상 값을 반환하는 한정자이다.
        public static int ReturnThreeValues(int value, out double half, out int twice)
        {
            //현재 메서드를 벗어나기 전에 out 매개 변수를 할당해야 한다.
            half = value / 2f;
            twice = value * 2;
            return value + 1;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if(int.TryParse(Console.ReadLine(), out int input))
            {
                var output1 = ReturnThreeValues(input, out double output2, out int output3);
                Console.WriteLine("Outputs: plus ont = {0}, half = {1:F}, twice = {2}",output1, output2, output3);
            }
        }
    }
}

/** 실행결과 : 18을 입력했을 때
Enter a number: 18
Outputs: plus ont = 19, half = 9.00, twice = 36
 */