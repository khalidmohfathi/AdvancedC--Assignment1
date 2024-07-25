using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    internal class MyClass : ISubtractable<MyClass>, IComparable<MyClass>
    {
        public int Value { get; set; }

        public MyClass(int val)
        {
            this.Value = val;
        }

        public int Subtract(MyClass other)
        {
            return this.Value - other.Value;
        }

        public int CompareTo(MyClass other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}
