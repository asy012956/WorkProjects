using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Person
    {
        //fields
        private string name;
        private int age;
        private string email;

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 && value > 100)
                {
                    throw new ArgumentException("Age must be between 1 and 100!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.email = "e-mail is not set";
                }
                else if (!value.Contains("@"))
                {
                    throw new ArgumentException("The e-mail address must contain @!");
                }
                else
                {
                    this.email = value;
                }
            }
        }


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email)
            : this(name, age)
        {
            this.Email = email;
        }

        //constructors
        //public Person(string name, int age, string email)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    this.Email = email;
        //}

        //public Person(string name, int age) : this(name, age, "")
        //{
        //}

        //methods
        public string PrintData()
        {
            return this.ToString();
            //return string.Format("Name: {0}, Age: {1}, Email: {2}", name, age, email);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", name, age, email);
        }
    }
}
