using System;
using System.Collections.Generic;
using System.Text;

namespace _10_SerializeGuys
{
    internal class Guy
    {
        public string Name {  get; set; }
        public HairStyle Hair {  get; set; }
        public Outfit Clothes { get; set; }
        public override string ToString()
        {
            return $"{Name} with {Hair} wearing {Clothes}";
        }
    }
}
