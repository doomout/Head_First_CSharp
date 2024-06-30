using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Puzzle
{
    // Clowns 클래스는 Picasso 클래스를 상속받음
    class Clowns : Picasso
    {
        // Clowns 클래스 생성자
        public Clowns() : base("Clowns") { }

        // Ear 메서드 구현 (재정의)
        public override int Ear()
        {
            return 7;
        }
    }
}
