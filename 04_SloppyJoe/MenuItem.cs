using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Printing;
using System.Text;

namespace _04_SloppyJoe
{
    class MenuItem
    {
        //public Random Randomizer = new Random(12345); //초기 값이 동일해서 계속 같은 값을 생성한다.
        public static Random Randomizer = new Random(); //정적 필드로 만들어서 하나의 인스턴스를 공유하도록 수정했다.
        public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = { "rye", "white", "wheat", "pupernickel", "a roll" };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.1M);
            var usCultureInfo = new System.Globalization.CultureInfo("en-US");
            Price = price.ToString("c", usCultureInfo);
        }
    }
}
