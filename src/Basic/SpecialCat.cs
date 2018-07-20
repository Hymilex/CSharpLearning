using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class SpecialCat:Animal,IShow
    {
        public void Show()
        {
            Console.WriteLine("This is a special cat which could dance for everyone.");
        }
    }
}
