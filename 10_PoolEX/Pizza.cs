using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _10_PoolEX
{
    internal class Pizza
    {
        private StreamWriter writer;
        public Pizza(StreamWriter writer)
        {
            this.writer = writer;
        }
        public void Idaho(Pineapple.Fargo f)
        {
            writer.WriteLine(f);
            writer.Close();
        }
    }
}
