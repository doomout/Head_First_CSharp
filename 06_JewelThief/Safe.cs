using System;
using System.Collections.Generic;
using System.Text;

namespace _06_JewelThief
{
    internal class Safe //금고 클래스
    {
        private string contents = "귀중한 보석";
        private string safeCombination = "12345";
        public string Open(string combination)
        {
            if(combination == safeCombination) return contents;
            return "";
        }
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = safeCombination;
        }
    }
}
