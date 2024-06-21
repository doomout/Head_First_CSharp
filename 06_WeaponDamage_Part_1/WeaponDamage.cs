using System;
using System.Collections.Generic;
using System.Text;

namespace _06_WeaponDamage_Part_1
{
    internal class WeaponDamage
    {
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

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

        //하위 클래스만 set 속성 변경 가능
        public int Damage { get; protected set; }

        
        protected virtual void CalculateDamage()
        {
            //하위 클래스에서 재정의 함
            Console.WriteLine("각 클래스에서 재정의 할꺼라 이게 호출되면 뭔가 잘못 된 것임 ㅡㅡ");
        }
    }
}
