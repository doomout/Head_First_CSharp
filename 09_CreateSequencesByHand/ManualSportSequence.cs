using System;
using System.Collections.Generic;
using System.Text;

namespace _09_CreateSequencesByHand
{
    internal class ManualSportSequence : IEnumerable<Sport> //Enumerable : 열거 가능
    {
        //Enumerator : 열거자
        public IEnumerator<Sport> GetEnumerator()
        {
            return new ManualSportEnumerator();
        }
     
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
