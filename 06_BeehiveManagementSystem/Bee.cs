﻿using System;
using System.Collections.Generic;
using System.Security.RightsManagement;
using System.Text;

namespace _06_BeehiveManagementSystem
{
    // 최상위 부모 클래스
    internal class Bee
    {
        public virtual float CostPerShift {  get;  }
        public string Job { get; private set; }
        public Bee(string job) 
        {
            Job = job;
        }
        public void WorkTheNextShift()
        {
            if(HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }
        protected virtual void DoJob() 
        { 
            //하위 클래스에서 재정의 한다.
        }
    }
}
