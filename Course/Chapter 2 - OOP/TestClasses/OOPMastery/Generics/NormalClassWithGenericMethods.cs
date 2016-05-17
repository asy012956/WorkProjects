using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Generics
{
    public class NormalClassWithGenericMethods
    {
        public double NonGenericProperty { get; set; }

        public bool GenericMethod<T>(T a, T b)
            where T : IEquatable<T>
        {
            return a.Equals(b);
        }

        public T2 GenericMethodThatReturnsGeneric<T2>(double a, double b)
            where T2 : new()
        {
            return new T2();
        }

        public T GenericMethodThatTakesGenericParameters<T>(T a, T b, double c)
        {
            return a;
        }
    }
}
