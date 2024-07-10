using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _08_LumberjacksAndFlapjacks
{
    internal class Lumberjack
    {
        public string Name {  get; set; }
        private Stack<Flapjack> flapjacksStack = new Stack<Flapjack>();
        public Lumberjack(string name) 
        {
            Name = name;
        }
        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjacksStack.Push(flapjack);
        }
        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjacksStack.Count > 0)
            {
                Console.WriteLine($"{Name} ate a {flapjacksStack.Pop().ToString().ToLower()} flapjack");
            }
        }
    }
}
