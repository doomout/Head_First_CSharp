using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ScaryClown
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
        void ScareAdults()
        {
            //$ - 문자열 보간, @ - 축어 리터럴
            Console.WriteLine($@"I am an ancient evil will haunt your dreams.
                        Behold my terrifying necklace with {random.Next(4, 10)} of my last victim's fingers.
                        Oh, also, before I forget.....");
        }
    }
}
