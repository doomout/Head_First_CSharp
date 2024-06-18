﻿using System;

namespace _05_SwordDamage_Console_Part_1
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            SwordDamage sd = new SwordDamage(RollDice());
           

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit : ");
                char key = Console.ReadKey().KeyChar;
                if (!(key == '0' || key == '1' || key == '2' || key == '3')) return;
                sd.Roll = RollDice();
                sd.Magic = (key == '1' || key == '3');
                sd.Flaming = (key == '2' || key == '3'); 
                Console.WriteLine($"\nRolled { sd.Roll}  for  { sd.Damage} HP\n");
            }
        }

        private static int RollDice()
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }
    }
}
