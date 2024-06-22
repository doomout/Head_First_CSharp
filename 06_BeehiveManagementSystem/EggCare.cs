﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06_BeehiveManagementSystem
{
    internal class EggCare : Bee
    {
        public const float CARE_PORGRESS_PER_SHIFT = 0.15f;
        public override float CostPerShift { get { return 1.35f; } }
        private Queen queen;
        public EggCare(Queen queen) : base("Egg Care")
        {
            this.queen = queen;
        }
        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PORGRESS_PER_SHIFT);
        }
    }
}
