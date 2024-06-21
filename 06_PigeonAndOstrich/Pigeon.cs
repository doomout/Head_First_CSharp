using System;
using System.Collections.Generic;
using System.Text;

namespace _06_PigeonAndOstrich
{
    internal class Pigeon : Bird
    {
        //LayEggs를 수정해서 알의 색상은 white로, 크기는 1~3cm로 재정의
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                //알 크기가 1~3cm 이기에 랜덤값으로 표현
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
            return eggs;
        }
    }
}
