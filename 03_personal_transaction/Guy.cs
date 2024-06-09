using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _03_personal_transaction
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }

        /// <summary>
        /// 돈을 주기 위해 이 사람의 지갑에서 돈을 꺼낸다.
        /// 돈이 부족하면 메시지를 출력한다.
        /// </summary>
        /// <param name="amount">줄 돈의 금액</param>
        /// <returns>
        /// 줄어든 돈의 금액. 돈이 부족하거나 금액이 유효하지 않은 경우 0을 반환
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            }
            if (amount > Cash) 
            { 
                Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// 돈을 받아서 지갑에 넣는다.
        /// 금액이 유효하지 않을 경우 메시지를 출력한다.
        /// </summary>
        /// <param name="amount">줄 돈의 금액</param>
        public void ReceiveCash(int amount) 
        {
            if (amount <= 0) 
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
