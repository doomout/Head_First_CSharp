using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Clowns
{
    internal class TallGuy : IClowns
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave
        {
            get { return "big shoes"; }
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }
    }
}
