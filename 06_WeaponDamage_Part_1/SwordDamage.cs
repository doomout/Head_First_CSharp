using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;

namespace _06_WeaponDamage_Part_1
{
    /// <summary>
    /// 칼 데미지 공식
    /// 보통 칼 데미지 : 주사위 3개 굴려서 나온 값 + 3
    /// 불타는 칼 데미지 : 기본 데미지 + 2
    /// 마법 칼 데미지 : (소수점 버림)(주사위 3개 굴려서 나온 값 * 1.75) + 기본 데미지 + 화염 데미지 
    /// 결과 값을 가까운 정수 HP 로 반올림
    /// </summary>
    internal class SwordDamage : WeaponDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        //모든 생성자는 startingRoll 매개 변수를 인수로 사용해서 base 키워드를 통해 부모 클래스의 생성자를 호출
        public SwordDamage(int startingRoll) : base(startingRoll) { }
        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) 
                magicMultiplier = 1.75M;
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll *  magicMultiplier)  + BASE_DAMAGE;
            if (Flaming) 
                Damage += FLAME_DAMAGE;
        }
    }
}
