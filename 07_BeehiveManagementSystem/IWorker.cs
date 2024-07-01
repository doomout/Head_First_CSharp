using System;
using System.Collections.Generic;
using System.Text;

namespace _07_BeehiveManagementSystem
{
    internal interface IWorker
    {
        string Job {  get; }
        void WorkTheNextShift();
    }
}
