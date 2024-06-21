using System;
using System.Collections.Generic;
using System.Text;

namespace _06_JewelThief
{
    internal class SafeOwner //금고 주인을 나타내는 클래스
    {
        private string valuables = "";
        public void ReceiveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"내 {valuables}을 돌려주셔서 감사합니다!");
        }
    }
}
