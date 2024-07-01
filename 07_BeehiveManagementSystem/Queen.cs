using System;

namespace _07_BeehiveManagementSystem
{
    internal class Queen : Bee
    { 
        public const float EGGS_PER_SHIFT = 0.45f;
        public const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        //private Bee[] workers = new Bee[0];
        private IWorker[] workers = new IWorker[0]; //인터페이스 적용
        private float eggs = 0;
        private float unassignedWorkers = 3;
        public string StatusReport { get; private set; }
        public override float CostPerShift { get { return 2.15f; } }

        public Queen() : base("Queen")
        {
            AssignBee("꽃꿀 수집");
            AssignBee("꿀 제조");
            AssignBee("알 관리");
        }

        private void AddWorker(IWorker worker) //인터페이스 적용
        {
            if(unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        private void UpdateStatusReport()
        {
            StatusReport = $"보고서 : \n{HoneyVault.StatusReport}\n" +
                $"\n알 갯수: {eggs:0.0}\n할당되지 않은 작업자: {unassignedWorkers:0.0}\n" +
                $"{WorkerStatus("꽃꿀 수집")}\n{WorkerStatus("꿀 제조")}" +
                $"\n{WorkerStatus("알 관리")}\n총 일벌 수: {workers.Length}";
        }

        public void CareForEggs(float eggsToConvert)
        {
            if(eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach (IWorker worker in workers) //인터페이스 적용
            {
                if (worker.Job == job)
                    count++;
            }
            string s = "s";
            if (count == 1) 
                s = "";

            return $"{count} {job} {s}";
        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "꽃꿀 수집":
                    AddWorker(new NectarCollector());
                    break;
                case "꿀 제조":
                    AddWorker(new HoneyManufacturer());
                    break;
                case "알 관리":
                    AddWorker(new EggCare(this));
                    break;
            }
            UpdateStatusReport();
        }

        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach (Bee worker in workers)
            {
                worker.WorkTheNextShift();
            }
            HoneyVault.ConsumeHoney(unassignedWorkers * HONEY_PER_UNASSIGNED_WORKER);
            UpdateStatusReport();
        }
    }
}
