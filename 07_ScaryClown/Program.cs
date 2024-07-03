using System;

namespace _07_ScaryClown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            IScaryClown iScaryClownReference = fingersTheClown;
            iScaryClownReference.ScareLittleChildren();
        }
    }
}
