using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ScaryClown
{
    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
