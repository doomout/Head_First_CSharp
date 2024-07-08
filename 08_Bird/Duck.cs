using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _08_Bird
{
    internal class Duck : Bird
    {
        public int Size { get; set; }
        public KindOfDuck Kind {  get; set; }
       
        //오리 정보 재정의(오리 정보 보임)
        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }
}
