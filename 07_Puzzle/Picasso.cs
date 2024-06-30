using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Puzzle
{
    abstract class Picasso : INose
    {
        private string face;
 
        // Face 속성 구현 (가상 속성)
        public virtual string Face
        {
            get { return face; }
        }

        // Ear 메서드는 추상 메서드로 선언
        public abstract int Ear();

        // 생성자를 통해 face 필드 초기화
        public Picasso(string face)
        {
            this.face = face; 
        }
    }
}
