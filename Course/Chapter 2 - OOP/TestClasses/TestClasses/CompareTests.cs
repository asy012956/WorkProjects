using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    public class CompareTests : IComparable<CompareTests>, IComparable<int>
    {
        public int Value { get; set; }

        public CompareTests()
        {
            this.Value = 120;
        }

        public int CompareTo(int other)
        {
            if (this.Value > other)
            {
                return -1;
            }

            if (this.Value < other)
            {
                return 1;
            }

            return 0;
        }

        public int CompareTo(CompareTests other)
        {
            if (this.Value < other.Value)
            {
                return -1;
            }

            if (this.Value > other.Value)
            {
                return 1;
            }

            return 0;
        }


    }
}
