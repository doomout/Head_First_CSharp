using System;
using System.Collections.Generic;
using System.Text;

namespace _06_BeehiveManagementSystem
{
    class Bee
    {
        //Bee 하위 클래스가 교대할 때 마다 소모되는 벌꿀의 양을 정의 
        public virtual float CostPerShift { get; }
        public string Job { get; private set; }
        
        //문자열을 받아서 Job속성 값을 설정
        public Bee(string job) 
        {
            Job = job;
        }
        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift)) 
            {
                DoJob();
            }
        }
        protected virtual void DoJob() { /*하위 클래스에서 이 메서드 재정의*/ }
    }
}
