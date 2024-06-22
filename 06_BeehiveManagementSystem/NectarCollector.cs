using System;
using System.Collections.Generic;
using System.Text;

namespace _06_BeehiveManagementSystem
{
    //작업 교대를 할 때마다 꽃꿀을 수집해 창고에 모읍니다.
    internal class NectarCollector : Bee
    {
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;
        public override float CostPerShift { get { return 1.95f; } }
        public NectarCollector() : base("Nectar Collector") { }
        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
