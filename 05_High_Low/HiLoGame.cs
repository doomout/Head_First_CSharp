using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _05_High_Low
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10; //처음 기본금 (10달러)
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1); //현재의 임의의 수
        private static int nextNumber = random.Next(1, MAXIMUM + 1); //다음 임의의 수
        private static int pot = 10; //판돈

        public static int GetPot() { return pot; }
        
        public static void Guess(bool higher) //판 돈과 임의 수와 비교해서 큰가? 작은가?
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
            {
                Console.WriteLine($"The current number is {currentNumber}, the next number is at least {half}");
            }
            else
            {
                Console.WriteLine($"The current number is {currentNumber}, the next is at most {half}");
            }
            pot--;
        }
    }
}
