using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    public class MyCompany : IEnumerable<string>
    {
        public string Martin { get; set; }
        public string Alexander { get; set; }
        public string Georgi { get; set; }
        public string Borko { get; set; }

        public MyCompany()
        {
            this.Martin = "Marto";
            this.Alexander = "Sasho";
            this.Georgi = "Joro";
            this.Borko = "Borko";
        }

        public IEnumerator<string> GetEnumerator()
        {
            var props = this.GetType().GetProperties();

            foreach (var prop in props)
            {
                yield return prop.GetValue(this).ToString();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
