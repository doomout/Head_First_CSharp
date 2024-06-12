using System;

namespace _04_RandomTestDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            int zeroToNine = random.Next(10); //0~9
            Console.WriteLine(zeroToNine);

            double randomDouble = random.NextDouble(); //0.0~1.0
            //정밀도 차이 확인
            Console.WriteLine(randomDouble * 100);               //67.6746803185319
            Console.WriteLine((float)randomDouble * 100F);      //67.674675
            Console.WriteLine((decimal)randomDouble * 100M); //67.674680318531900

            int zeroOrOne = random.Next(2); //true, false
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);
        }
    }
}
