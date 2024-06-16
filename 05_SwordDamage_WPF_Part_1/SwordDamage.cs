using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _05_SwordDamage_WPF_Part_1
{
    /// <summary>
    /// 룰 설명
    /// 보통 칼 공격시 : 주사위 3개 합 + 기본 데미지 3HP 더함
    /// 불타는 칼 공격시 : 화염 데미지 2 HP
    /// 마법 칼 공격시 : (int)(주사위 3개 합 * 1.75) + 기본 데미지 + 화염 데미지
    /// </summary>
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        private decimal MagicMultiplier = 1M;
        private int FlamingDamage = 0;
        public int Damage;

        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
            Debug.WriteLine($"CalulateDamage finished: {Damage} (roll : {Roll})");
        }

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
            Debug.WriteLine($"SetMagic finished: {Damage} (roll : {Roll})");
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
            Debug.WriteLine($"SetFlaming finished: {Damage} (roll : {Roll})");
        }
    }
}
