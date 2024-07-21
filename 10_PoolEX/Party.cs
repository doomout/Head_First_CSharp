using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _10_PoolEX
{
    internal class Party
    {
        private StreamReader reader;
        public Party(StreamReader reader)
        {
            this.reader = reader;
        }
        public void HowMuch(StreamWriter q) 
        {
            q.WriteLine(reader.ReadLine());    
            reader.Close();
        }
    }
}
