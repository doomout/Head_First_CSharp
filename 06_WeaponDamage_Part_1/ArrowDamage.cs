using System;
using System.Collections.Generic;
using System.Text;

namespace _06_WeaponDamage_Part_1
{
    internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        /// <summary>
        /// 생성자는 기본 Magic, Flaming 값과 주사위 3개를 굴려서 나온 값을 기준으로 데미지를 계산
        /// </summary>
        /// <param name="startingRoll">주사위 3개를 굴려서 나오는 값</param>
        public ArrowDamage(int startingRoll)
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
        public void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);  //Math.Ceiling 반올림
            else Damage = (int)Math.Ceiling(baseDamage); //Math.Ceiling 반올림
        }
    }
}
