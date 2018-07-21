using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class Peppis
    {
        private Peppi[] peppiArray;
        public Peppis()
        {
            peppiArray = new Peppi[] { 
            new Peppi("孙悟空"),
            new Peppi("沙僧"),
            new Peppi("唐三藏")
            };
        }
        public Peppi this[int index]
        {
            get { return peppiArray[index]; }
        }
        public int Count
        {
            get { return peppiArray.Length; }
        }

        /// <summary>
        /// yield 这个属性就比较优秀 让对象像数组一样的foreach一样优雅。
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Peppi> GetEnumerator()
        {
            for (int index = 0; index < peppiArray.Length; index++)
            {
                yield return peppiArray[index];
            }
        }
    }
}
