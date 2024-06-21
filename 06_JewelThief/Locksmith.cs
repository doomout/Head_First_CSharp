using System;
using System.Collections.Generic;
using System.Text;

namespace _06_JewelThief
{
    internal class Locksmith //자물쇠를 딸 수 있는 열쇠공 클래스
    {
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this); //자물쇠를 따고
            string safeContents = safe.Open(Combination); //금고를 열고
            ReturnContents(safeContents, owner); //귀중품을 주인에게 돌려준다.
        }
        public string Combination { private get; set; }

        //도둑이 이 메서드가 아닌 다른 메서드를 재정의 사용하기 위해 virtual를 선언해줬다.
        protected virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
