using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    internal class Range<T> where T : IComparable<T> , ISubtractable<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }

        public Range(T min, T max)
        {
            this.Maximum = max;
            this.Minimum = min;
        }
         
        public bool IsInRange(T val)
        {
            return (val.CompareTo(Minimum) >= 0) && (val.CompareTo(Maximum) <= 0);
        }
        public int Length()
        {
            return Maximum.Subtract(Minimum);
        }
    }
}
