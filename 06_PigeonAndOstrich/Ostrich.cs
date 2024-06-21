using System;
using System.Collections.Generic;
using System.Text;

namespace _06_PigeonAndOstrich
{
    internal class Ostrich : Bird
    {
        //타조알 색상 speckled 크기 12~13cm로 재정의 
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, "speckled");
            }
            return eggs;
        }
    }
}
