using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _04_AbilityScore
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;
        public void CalculateAbilityScore()
        {
            // 굴리기 값을 DivideBy 필드 값으로 나눈다.
            double divided = RollResult / DivideBy;
            //AddAmount 를 나눗셈 결과에 더한다
            int added = AddAmount + (int)divided;
            //결과 값이 너무 적으면 Minimum 값을 사용한다.
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
