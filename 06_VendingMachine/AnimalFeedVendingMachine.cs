using System;
using System.Collections.Generic;
using System.Text;

namespace _06_VendingMachine
{
    internal class AnimalFeedVendingMachine : VendingMachine
    {
        public override string Item //속성에도 override 사용 가능
        {
            get { return "a handful of animal feed"; }
        }
        protected override bool CheckAmount(decimal money)
        {
            return money >= 1.25M;
        }
    }
}
