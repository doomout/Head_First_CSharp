using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Clowns
{
    // IClowns 인터페이스는 FunnyThingIHave 프로퍼티와 Honk 메서드를 정의합니다.
    internal interface IClowns
    {
        string FunnyThingIHave { get; }
        void Honk();
    }
}
