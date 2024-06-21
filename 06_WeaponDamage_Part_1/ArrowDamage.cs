using System;
using System.Collections.Generic;
using System.Text;

namespace _06_WeaponDamage_Part_1
{
    /// <summary>
    /// 화살 데미지 공식
    /// 보통 화살 데미지 : 주사위 1개 굴려서 나온 값 * 0.35
    /// 마법 화살 데미지 : 기본 데미지 * 2.5
    /// 불타는 화살 데미지 : 기본 데미지 + 1.25
    /// 결과 값을 가까운 정수 HP 로 반올림
    /// </summary>
    internal class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
        public ArrowDamage(int startingRoll) : base(startingRoll) { }
        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) 
                baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) 
                Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else 
                Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
