using System;
using System.Collections.Generic;
using System.Text;

namespace _04_SharpenYourPencil
{
    internal class Elephant
    {
        public int EarSzie;
        public string Name;

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSzie + " inches tall.");
        }
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " Heard a message");
            Console.WriteLine(whoSaidIt.Name + " side this: " +  message);
         }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
