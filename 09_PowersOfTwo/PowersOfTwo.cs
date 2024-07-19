using System;
using System.Collections.Generic;
using System.Collections;

namespace _09_PowersOfTwo
{
    internal class PowersOfTwo : IEnumerable<int>
    {
        // IEnumerable<int>의 GetEnumerator 메서드를 구현합니다.
        public IEnumerator<int> GetEnumerator()
        {
            // int.MaxValue의 로그 값을 2를 밑으로 구하고 반올림하여 최대 지수를 계산합니다.
            var maxPower = Math.Round(Math.Log(int.MaxValue, 2));

            // 0부터 maxPower-1까지 반복합니다.
            for (int power = 0; power < maxPower; power++)
            {
                // 2의 power 제곱 값을 반환합니다.
                yield return (int)Math.Pow(2, power);
            }
        }
        // IEnumerable 인터페이스의 GetEnumerator 메서드를 구현합니다.
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
