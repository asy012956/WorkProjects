using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Generics
{
    public class GenericClass<T>
        where T : IEquatable<T> 
    {
        public T GenericProperty { get; set; }

        public void GenericParametersInMethod(T a, T b)
        {
            
        }

        public bool GenericEquals(T a, T b)
        {
            return a.Equals(b);
        }

        public T GenericReturningMethod(int a, int b)
        {
            return this.GenericProperty;
        }

        public T GenericBOTH(T a, T b, int c)
        {
            return this.GenericProperty;
        }
    }
}
