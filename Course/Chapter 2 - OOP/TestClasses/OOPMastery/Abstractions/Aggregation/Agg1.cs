using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMastery.Abstractions.Aggregation
{
    public class Agg1
    {
        public Agg1 Something = new Agg1();

        public Agg2 Elements { get; set; }

        public Agg1()
        {
            this.Elements = new Agg2();
        }


    }
}
