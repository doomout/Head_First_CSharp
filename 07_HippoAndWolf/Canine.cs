using System;
using System.Collections.Generic;
using System.Text;

namespace _07_HippoAndWolf
{
    interface IPackHunter { void HuntInPack(); }
    internal abstract class Canine : Animal
    {
        // 무리 속에 속해 있는지 여부를 나타내는 속성, 기본값은 false
        public bool BelongsToPack { get; protected set; } = false;
        
    }
   
}
