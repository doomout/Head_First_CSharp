﻿using System;

namespace _04_AbilityScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true) 
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Oress Q to quit, any other key to conttinue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [ " + lastUsedValue + " ]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine(" using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine(" usting default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [ " + lastUsedValue + " ]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value)) 
            {
                Console.WriteLine(" using value " + value);
                return value;
            } 
            else 
            {
                Console.WriteLine(" usting default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}
