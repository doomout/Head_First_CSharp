using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ScaryClown
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount; //읽기 전용으로 수정
        public ScaryScary(string funnyThing, int scaryThingCount) : base(funnyThing)
        {
           
            this.scaryThingCount = scaryThingCount;
        }
        public string ScaryThingIHave { get { return $"{scaryThingCount} spiders"; } }
        public void ScareLittleChildren()
        {
            Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}!");
        }
        
    }
}
