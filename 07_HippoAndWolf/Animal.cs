using System;
using System.Collections.Generic;
using System.Text;

namespace _07_HippoAndWolf
{
    interface ISwimmer { void Swim(); }
    internal abstract class Animal
    {
        // 추상 메서드로서, Animal 클래스를 상속받는 클래스에서 반드시 구현해야 함
        public abstract void MakeNois();
    }
}
