using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;

namespace _05_SwordDamage_Console_Part_1
{
    internal class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
       private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// 생성자는 기본 Magic, Flaming 값과 주사위 3개를 굴려서 나온 값을 기준으로 데미지를 계산
        /// </summary>
        /// <param name="startingRoll">주사위 3개를 굴려서 나오는 값</param>
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }


        /// <summary>
        /// 주사위 3개를 굴려서 나온 값을 설정하거나 반환
        /// </summary>
        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
     

        /// <summary>
        /// 계산된 데미지 값을 저장
        /// </summary>
        public int Damage { get; private set; }

        private bool magic;
        /// <summary>
        /// 마법칼이면 true, 아니면 false 반환
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// 불타는 칼이면 true, 아니면 false 반환
        /// </summary>
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

        /// <summary>
        /// 현재 속성들을 기준으로 데미지를 계산한다.
        /// </summary>
        //public decimal MagicMultiplier = 1M; //기존 코드
        //public int FlamingDamage = 0; //기존 코드
        public void CalculateDamage()
        {
            //Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage; //기존 코드
            decimal magicMultiplier = 1M;
            if (Magic) 
                magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming) 
                Damage += FLAME_DAMAGE;
        }

        
        
        /** 기존 코드
        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
        */
    }
}
