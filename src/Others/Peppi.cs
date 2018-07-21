using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Others
{
    public class Peppi
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Peppi(string name)
        {
            this.name = name;
        }
    }

}
