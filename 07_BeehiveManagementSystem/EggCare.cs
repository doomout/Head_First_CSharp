﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07_BeehiveManagementSystem
{
    internal class EggCare : Bee
    {
        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;
        public override float CostPerShift { get { return 1.35f; } }
        private Queen queen;
        public EggCare(Queen queen) : base("알 관리")
        {
            this.queen = queen;
        }
        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
