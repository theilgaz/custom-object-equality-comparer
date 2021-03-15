using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomObjectEqualityComparer
{
    public class MyObjectEqualityComparer : IEqualityComparer<MyObject>
    {
        public bool Equals(MyObject x, MyObject y)
        {
            return x.Value1 == y.Value1 &&
                   x.Value2 == y.Value2 &&
                   x.Value3 == y.Value3;
        }

        public int GetHashCode(MyObject obj)
        {
            return base.GetHashCode();
        }
    }
}
