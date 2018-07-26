using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTips
{
    // Icomparer < in T >
    class Testcomparer:IComparer<object>
    {
        public int Compare(object obj1, object obj2)
        {
            return obj1.ToString().CompareTo(obj2.ToString());
        }
    }
}
