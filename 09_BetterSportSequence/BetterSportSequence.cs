using System;
using System.Collections.Generic;
using System.Text;

namespace _09_BetterSportSequence
{
    internal class BetterSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;
            for (int i = 0; i <= maxEnumValue; i++)
            {
                //yield return 문을 사용해서 GetEnumerator() 메서드를 구현하고 직접 열거 가능한 시퀀스를 만들 수 있다.
                yield return (Sport)i; 
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Sport this[int index]
        {
            get => (Sport)index;
        }
    }
}
