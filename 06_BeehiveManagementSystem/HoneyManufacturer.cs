﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06_BeehiveManagementSystem
{
    internal class HoneyManufacturer: Bee
    {
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;
        public override float CostPerShift { get { return 1.7f; } }
        public HoneyManufacturer() : base("꿀 제조") { }
        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
