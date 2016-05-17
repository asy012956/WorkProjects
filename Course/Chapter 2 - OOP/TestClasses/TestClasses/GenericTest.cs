using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    public class GenericTest<T> where T : IComparable<T>
    {
        public int CompareTheTwo(T one, T two)
        {
            return one.CompareTo(two);
        }
    }

    public class GenericComparator
    {
        public int CompareTheTwo<T>(T one, T two) where T : IComparable<T>
        {
            return one.CompareTo(two);
        }
    }

    public class MultipleGenericComparator
    {
        public int Compare<T, A>(T one, A two) where T : IComparable<A>
        {
            return one.CompareTo(two);
        }
    }
}
