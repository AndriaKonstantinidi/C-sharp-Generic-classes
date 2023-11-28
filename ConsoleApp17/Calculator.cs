using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Calculator<T> where T : IComparable<T>
    {
        public bool IsEqual(T value1, T value2)
        {
            return value1.CompareTo(value2) == 0;
        }
        public bool IsBigger(T value1, T value2)
        {
            return value1.CompareTo(value2) > 0;
        }
        public bool IsSmaller(T value1, T value2)
        {
            return value1.CompareTo(value2) < 0;
        }
    }
}
