using System;

namespace _07_Clowns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "kim" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            tallGuy.Honk();
        }
    }
}
