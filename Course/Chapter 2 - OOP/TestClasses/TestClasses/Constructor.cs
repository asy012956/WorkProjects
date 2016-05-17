using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    public class ConstrTest
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> FriendNames { get; set; }

        public ConstrTest(string asdf)
        {
            this.Name = asdf;
            this.FriendNames = new List<string>();
        }

        public ConstrTest(string name, int age)
            : this(name)
        {
            this.Age = age;
        }

        public ConstrTest(string name, int age, int number)
            : this(name, age)
        {
            this.Number = number;
        }
    }
    
    public class CTest2 : ConstrTest
    {
        public int Height { get; set; }

        public CTest2(string name)
            : base(name)
        {

        }

        public CTest2(string name, int age, int height)
            : base(name, age)
        {
            this.Height = height;
        }

        public CTest2(string name, int age, int height, int number)
            : this(name, age, height)
        {

        }
    }
    
}
