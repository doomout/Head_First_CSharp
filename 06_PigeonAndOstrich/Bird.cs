using System;
using System.Collections.Generic;
using System.Text;

namespace _06_PigeonAndOstrich
{
    abstract class Bird
    {
        public static Random Randomizer = new Random();

        //Egg 메서드를 재정의 가능하도록 virtual 추가
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs는 절대 호출되어서는 안 됩니다.");
            return new Egg[0];
        }
    }
}
