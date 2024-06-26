using System;
using System.Collections.Generic;
using System.Text;

namespace _06_WeaponDamage_Part_1
{
    internal abstract class WeaponDamage
    {
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
        protected abstract void CalculateDamage();
        /** 추상화 함으로 필요 없어진 코드
        {
            //하위 클래스에서 재정의 함
            Console.WriteLine("각 클래스에서 재정의 할꺼라 이게 호출되면 뭔가 잘못 된 것임 ㅡㅡ");
        }
        */
        //하위 클래스만 set 속성 변경 가능
        public int Damage { get; protected set; }

        private int roll;
        public int Roll
        {
            get { return roll; }
            set 
            { 
                roll = value; CalculateDamage(); 
            }
        }

        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value; 
                CalculateDamage();
            }
        }
        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
    }
}
