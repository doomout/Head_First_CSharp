using System;
using System.Collections.Generic;
using System.Text;

namespace _06_JewelThief
{
    internal class JewelThief : Locksmith //악당이 열쇠공 클래스를 상속 받았다!
    {
        private string stolenJewels;

        //ReturnContents() 를 주인에게 돌려주는 것을 재정의 해서 도둑이 훔치는 걸로 변환한줄 알았으나...
        //실행 해보면 하단의 메서드는 실행되지 않는다.
        //만약 하위 클래스에서 기본 클래스에 있는 메서드와 똑같은 이름의 메서드를 추가하면
        //기본 클래스의 메서드는 재정의 되는 것이 아니라 숨겨진다.
        //이 메서드가 실행 되게 하려면 override  를 해야 한다.
        protected override void ReturnContents(string safeContents, SafeOwner owner) 
        {
            stolenJewels = safeContents;
            Console.WriteLine($"나는 지금 보석을 훔치고 있어요! 나는 {stolenJewels}를 훔쳤어 ㅋ");
        }
    }
}
