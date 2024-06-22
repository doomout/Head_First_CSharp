﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06_BeehiveManagementSystem
{
    //창고에 있는 꽃꿀로 벌꿀을 만든다.
    internal class HoneyManufacturer : Bee
    {
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;
        public override float CostPerShift { get { return 1.7f; } }
        public HoneyManufacturer() : base("Honey Manufacturer") { }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
