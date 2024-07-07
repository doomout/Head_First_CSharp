using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Ducks
{
    internal class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            //결과가 음수인 경우, 객체 x가 객체 y 앞에 와야 한다. 순서:  x , y
            if (x.Kind < y.Kind)
                return -1;
            //결과가 양수인 경우, 객체 x가 객체 y 뒤에 와야 한다. 순서: y, x
            if (x.Kind > y.Kind)
                return 1;
            //결과가 0인 경으, 객체 x와 객체 y가 동등하다.
            return 0;
        }
    }
}
