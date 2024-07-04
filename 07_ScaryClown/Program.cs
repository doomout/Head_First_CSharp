using System;

namespace _07_ScaryClown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            if(fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareLittleChildren();
            }
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());
        }
    }
}
