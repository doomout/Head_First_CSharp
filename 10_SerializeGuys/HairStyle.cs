using System;
using System.Collections.Generic;
using System.Text;

namespace _10_SerializeGuys
{
    internal class HairStyle
    {
        public HairColor Color { get; set; }
        public float Length {  get; set; }
        public override string ToString()
        {
            return $"{Length:0.0} inch {Color} hair";
        }
    }
}
