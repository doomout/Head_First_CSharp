using System;
using System.Collections.Generic;
using System.Text;

namespace _11_PassGuyByReference
{
    internal class Guy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"a {Age}-year-old named {Name}";
        }
    }
}
