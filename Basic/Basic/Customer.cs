using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Customer:ICustomCompare
    {
        private int age;
        public int Age
        {
            get;
            set;
        }
        public Customer()
        {
            age = 12;
            Console.WriteLine("This is a default constructor.");
        }
        public Customer(int age)
        {
            this.Age = age;
        }
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            //将object 转换为 Customer
            Customer customer = (Customer)value;
            if (this.Age < customer.Age)
            {
                return -1;
            }
            if (this.Age > customer.age)
            {
                return 1;
            }
            return 0;
        }
    }
}
