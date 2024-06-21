using System;
using System.Collections.Generic;
using System.Text;

namespace _06_VendingMachine
{
    internal class VendingMachine
    {
        public virtual string Item {  get; }

        //현재 클래스의 하위 클래스만 접근 가능
        //올바른 금액을 투입했는지 체크가 false를 반환 하는 이유 : 구체적인 것은 하위 클래스에서 구현 할 것
        protected virtual bool CheckAmount(decimal money) 
        { 
            return false;
        }
        public string Dispense(decimal money)
        {
            if (CheckAmount(money)) 
                return Item;
            else 
                return "Please enter the right amount";
        }
    }
}
