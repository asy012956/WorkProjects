using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThreeTasks
{
    class TestClass
    {
        public void Test()
        {
            string calculation = "20+10-5";
            DataTable whatever = new DataTable();
            var result = whatever.Compute(calculation, "");
            Console.WriteLine(result);
        }
    }
}
