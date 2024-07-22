using System;
using System.Collections.Generic;
using System.Text;

namespace _10_SerializeGuys
{
    internal class Outfit
    {
        public string Top {  get; set; }
        public string Bottom { get; set; }
        public override string ToString()
        {
            return $"{Top} and {Bottom}";
        }
    }
}
